using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Social_Movie_Manager.Pages;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Social_Movie_Manager
{
    public sealed partial class Slide_Menu : UserControl
    {
        public Slide_Menu()
        {
            this.InitializeComponent();

            //Fill the menulist with the different pages.
            string[] menuItems = new string[6] { "Home", "Explore", "Wishlist", "Blacklist", "Groups", "About" };
            ListMenuItems.ItemsSource = menuItems;
        }

        /// <summary>
        /// Navigate to the page the user tapped on. Don't navigate if the user is already on the page.
        /// </summary>
        private void ListMenuItems_ItemClick(object sender, ItemClickEventArgs e)
        {
            string clickedItem = e.ClickedItem.ToString();
            var currentPage = (Window.Current.Content as Frame).Content.GetType();

            switch (clickedItem)
            {
                case "Home":
                    if (currentPage.Name != "MainPage")
                        (Window.Current.Content as Frame).Navigate(typeof(MainPage));
                    break;

                case "Explore":
                    if (currentPage.Name != "ExplorePage")
                        (Window.Current.Content as Frame).Navigate(typeof(ExplorePage));
                    break;

                case "Wishlist":
                    if (currentPage.Name != "WishlistPage")
                        (Window.Current.Content as Frame).Navigate(typeof(WishlistPage));
                    break;

                case "Blacklist":
                    if (currentPage.Name != "BlacklistPage")
                        (Window.Current.Content as Frame).Navigate(typeof(BlacklistPage));
                    break;

                case "Groups":
                    if (currentPage.Name != "GroupsPage")
                        (Window.Current.Content as Frame).Navigate(typeof(GroupsPage));
                    break;

                case "About":
                    if (currentPage.Name != "AboutPage")
                        (Window.Current.Content as Frame).Navigate(typeof(AboutPage));
                    break;
            }
        }
    }
}