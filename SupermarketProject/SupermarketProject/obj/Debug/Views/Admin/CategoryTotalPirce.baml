   M S B A M L   `   `   `  ����M  ISupermarketProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SupermarketProject.ViewModelsSupermarketProject.ViewModels  5   	   7    1SupermarketProject.Views.Admin.CategoryTotalPirce   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:SupermarketProject.ViewModels     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ CategoryTotalPirce��5	   	   $	��550��6$   $	��800��61    � DataContext 5
      8   2SupermarketProject.ViewModels.CategoryTotalPriceVM  5   
   .��5      � ���#7F5F7C.+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��	totalGrid��5      $��85,129,125,130q�6$   $��Times New Roman)�6=   $��20(�6Z   $
��Bold"�6h   $��Italic$�6z      AutoGenerateColumns .  $��Visible=�6�   ��6�   �� *CategoryTotalPrices+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Category name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 260 6<      FontSize$ 16Q�6i      
FontFamily$ Times New Roman)�6w   	   
FontWeight$
	 Bold"�6�   
   	FontStyle$
 Italic$�6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6H   �� *CategoryName+6�     5      $ Total price��6%   $	 200 6l   $ 16Q�6y   $ Times New Roman)�6�   $
	 Bold"�6�   $
 Italic$�6�    6:   �� *Total+ �� StringFormat$ {0:C}��6�   5      �� 5   
   $
��Left=�6   $��20,4,0,0q�6/   $
��Wrap=�6A   $��TOTAL PRICE PER CATEGORY ��6U   $	��Top=�5      $��Times New Roman)�6   $��30(�68   $
��Bold"�6F   $	��775��6X   5      5      