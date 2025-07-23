
using maui.Models;
using System.Collections.ObjectModel;



namespace maui
{
    public partial class MainPage : ContentPage
    {
       public ObservableCollection<InventoryItem> InventoryItems { get; set; }= [];

        public MainPage()
        {
            InitializeComponent();
            InventoryItems.Add(new InventoryItem(1000, "Laptop", 999.99m));
            InventoryItems.Add(new InventoryItem(2000, "Mouse", 19.99m));
            BindingContext= this;
        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {
            if (int.TryParse(ItemNOEntry.Text, out int itemNo)&&
                !string.IsNullOrEmpty(DescriptionEntry.Text)&&
                decimal.TryParse(PriceEntry.Text,out decimal price))
            {
                InventoryItems.Add(new InventoryItem(itemNo, DescriptionEntry.Text, price));
                ClearEntries();
            }
            else
            {
                DisplayAlert("Error", "Please enter Valid values for all feilds.", "ok");

            }
        }

        private void btnUpdate_Clicked(object sender, EventArgs e)
        {
            if (InventoryListView.SelectedItem is InventoryItem selectedItem)
            {
                if (int.TryParse(ItemNOEntry.Text, out int itemNo) &&
                !string.IsNullOrEmpty(DescriptionEntry.Text) &&
                 decimal.TryParse(PriceEntry.Text, out decimal price))
                {
                    selectedItem.ItemNo = itemNo;
                    selectedItem.Description = DescriptionEntry.Text;
                    selectedItem.Price = price;

                   // InventoryItems[InventoryItems.IndexOf(selectedItem)] = selectedItem;
                    //ClearEntries();

                }

                else
                {

                }




            }
        }

        private void btnDelete_Clicked(object sender, EventArgs e)
        {
            if (InventoryListView.SelectedItem is InventoryItem selectionItem)
            { 
                InventoryItems.Remove(selectionItem);
                ClearEntries();
            }

        }

        private void InventoryListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem is InventoryItem selectedItem)
            {
                ItemNOEntry.Text = selectedItem.ItemNo.ToString();
                DescriptionEntry.Text = selectedItem.Description;
                PriceEntry.Text = selectedItem.Price.ToString("F2");
            }
        }
        private void ClearEntries()
        {
            ItemNOEntry.Text = string.Empty;
            DescriptionEntry.Text = string.Empty;
            PriceEntry.Text = string.Empty;
        }
    }
}
