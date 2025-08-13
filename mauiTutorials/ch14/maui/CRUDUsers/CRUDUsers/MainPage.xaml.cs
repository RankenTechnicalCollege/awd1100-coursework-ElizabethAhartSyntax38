using CRUDUsers.DATA;
using CRUDUsers.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;


namespace CRUDUsers
{
    
    public partial class MainPage : ContentPage
    {
        private readonly DataContext _dataContext;
        public ObservableCollection<User> Users { get; set; }
        
        public MainPage(DataContext dataContext)
        {
            

            InitializeComponent();
            _dataContext = dataContext;
            Users = new ObservableCollection<User>();

            BindingContext = this; //MVVM pattern: setting the bindingContext to this page


            LoadUsers();
        }

        private async void LoadUsers()
        {
            try
            {
                await _dataContext.Database.EnsureCreatedAsync();
                var users = await _dataContext.Users.ToListAsync();
                foreach (var user in users)
                {
                    users.Add(user);
                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"failed to load users {ex.Message}", "ok");
            }

        }
        private async void OnAddUserClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameEntry.Text))
            {
                await DisplayAlert("Enter", "Name cannot be empty", "ok");
                return;

            }
            try
            {
                var newUser = new User { Name = NameEntry.Text.Trim() };
                _dataContext.Users.Add(newUser);
                await _dataContext.SaveChangesAsync();

                Users.Add(newUser);
                NameEntry.Text = string.Empty;
                await DisplayAlert("Success", "User Added", "ok");

            }
            catch (Exception ex)
            {
                await DisplayAlert("error", $"failed to add user:{ex.Message}", "ok");
                return;
            }
        }
        private async void ODeleteUserClicked(object sender, EventArgs e)
        {
            if (sender is Button button && button.CommandParameter is User userToDelete)
            {

                bool Confirmed = await DisplayAlert("Confirm Delete", $"Are u sure?{userToDelete.Name}?", "Yes", "No");
                if (!Confirmed)
                {
                    return;
                }
                try
                {
                    _dataContext.Users.Remove(userToDelete);
                    await _dataContext.SaveChangesAsync();
                    Users.Remove(userToDelete);
                    await DisplayAlert("Success", $"UserDeleted", "ok");

                }
                catch (Exception ex)
                {
                    await DisplayAlert("Error", $"Failed to Error", "ok");
                }
            }
        }
        private async void OnUserEditUserClicked(object sender, EventArgs e)
        {
            if (sender is Button button && button.CommandParameter is User userToEdit)
            {
                string newName = await DisplayPromptAsync("Edit User", "Enter new name:", initialValue: userToEdit.Name);
                if (string.IsNullOrWhiteSpace(newName))
                {
                    await DisplayAlert("Enter", "Name cannot be empty", "ok");
                    return;

                }
                try
                {
                    userToEdit = new User { Name = NameEntry.Text.Trim() };
                    _dataContext.Users.Update(userToEdit);
                    await _dataContext.SaveChangesAsync();

                    Users.Add(userToEdit);
                    NameEntry.Text = string.Empty;
                    await DisplayAlert("Success", "User Added", "ok");
                    var index=Users.IndexOf(userToEdit);
                    if(index != -1)
                    {
                        Users[index]= userToEdit;
                    }
                    await DisplayAlert("Success", "UserEdited", "User added", "OK");

                }
                catch (Exception ex)
                {
                    await DisplayAlert("error", $"failed to edit user:{ex.Message}", "ok");
                    return;
                }








            }
        }
    }
}

       
        



