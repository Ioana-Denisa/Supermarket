   M S B A M L   `   `   `  ����M  ISupermarketProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SupermarketProject.ViewModelsSupermarketProject.ViewModels  5   	   M+clr-namespace:SupermarketProject.ConvertersSupermarketProject.Converters  5   	   M+clr-namespace:SupermarketProject.ExceptionsSupermarketProject.Exceptions  6�   /    )SupermarketProject.Views.Admin.StockAdmin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:SupermarketProject.ViewModels     5   	   FlocalConverter+clr-namespace:SupermarketProject.Converters     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  6L   <
Exceptions+clr-namespace:SupermarketProject.Exceptions  6�     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ Stock��5
   	   $	��550��6   $	��800��6$    � DataContext 5      +   %SupermarketProject.ViewModels.StockVM  5   
   .��5      � ���#7F5F7C.+�5   
   �� $
��Left=�6   $��
480,28,0,0q�60    �� Orientation$ 
Horizontal=�6D   $	��Top=�6]   $	��260��6u   $	��240��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�    � 	Resources 5      0   *SupermarketProject.Converters.StockConvert   stockConvert��%   &	          5      6.   5      z�5      V� 5      .~�5      �� �� 5       �� AngleX$ -0.233Q�6$   �� 5      T� 5       T� X$ -0.396Q�6)   5      .+�5      �� $	��Add��6   ���	#FFCCBFDC���	#FFAE82E2$��Times New Roman)�6R   $��25(�6o   $
��Bold"�6}   $��Italic$�6�   $��50��6�   $	��145��6�   $��10,-110,0,0q�6�   ��6�   �� *
AddCommand+��5      `� 5       `� 	Converter# [  6#   .1�5      �� 	 �� ElementName$	 cbxProducts��6"   
 �� Path$
 SelectedItem.ProductID�6<   �� 5      $	 txtQuantity��6"   $

 Text�6<   �� 5       $	 cbxUnit��6"   $
 SelectedItem.Content�68   �� 5!      $	 
supplyDate��6"   $
 SelectedDate�6;   �� 5"      $	 expirationDate��6"   $
 SelectedDate�6?   �� 5#      $	 txtPurchasePrice��6"   $

 Text�6A   5$      5&      �� 5'      $��Update��6   ���	#FFCCBFDC���	#FFAE82E2$��Times New Roman)�6V   $��25(�6s   $
��Bold"�6�   $��Italic$�6�   $��50��6�   $	��145��6�   $��-145,10,10,0q�6�   ��6�   �� *UpdateCommand+��6�   �� $	 	stockGrid��$
 SelectedItem��� 5(      $��Delete��6   ���	#FFCCBFDC���	#FFAE82E2$��Times New Roman)�6U   $��25(�6r   $
��Bold"�6�   $��Italic$�6�   $��50��6�   $	��145��6�   $��-165,130,0,0q�6�   ��6�   �� *DeleteCommand+��6�   �� $	 	stockGrid��$
 SelectedItem�5)      �� 5*   
   $
��Left=�6   $��	30,50,0,0q�60   $ Vertical=�6C   $	��Top=�6Z   $	��164��6r   $	��265��6~   .+�5+      �� $
��Wrap=�6   $��Product��6,   $��	30,0,0,15q�6;   $��Times New Roman)�6N   $��18(�6k   $
��Bold"�6y   $��Italic$�6�   �� 5,      $
��Wrap=�6   $��Quantity��6,   $��	30,0,0,15q�6<   $��Times New Roman)�6O   $��18(�6l   $
��Bold"�6z   $��Italic$�6�   �� 5-      $
��Wrap=�6   $
��Unit��6,   $��	30,0,0,10q�68   $��Times New Roman)�6K   $��18(�6h   $
��Bold"�6v   $��Italic$�6�   �� 5.      $
��Wrap=�6   $��
SupplyDate��6,   $��	30,4,0,10q�6>   $��Times New Roman)�6Q   $��18(�6n   $
��Bold"�6|   $��Italic$�6�   �� 5/      $
��Wrap=�6   $��ExpirationDate��6,   $��	30,4,0,10q�6B   $��Times New Roman)�6U   $��18(�6r   $
��Bold"�6�   $��Italic$�6�   �� 50      $
��Wrap=�6   $��PurchasePrice��6,   $��	30,0,0,10q�6A   $��Times New Roman)�6T   $��18(�6q   $
��Bold"�6   $��Italic$�6�   �� 51      $
��Wrap=�6   $��SellingPrice��6,   $��	30,0,0,10q�6@   $��Times New Roman)�6S   $��18(�6p   $
��Bold"�6~   $��Italic$�6�   52      �� 53   
   $��130,38,400,190q�6   .+�54      �� -   5        $��cbxProducts��54      $	��156��6*   $��	0,10,0,10q�66   $��25��6I    �� DisplayMemberPath$
 Name��6z    �� SelectedValuePath$ ID��6�   ��6U   �� *ProductsList+ �� SelectedValue 6�   �� *SelectedProduct.ProductID+ �� UpdateSourceTrigger$ PropertyChanged=��� 55      -   5         ��Name$ txtQuantity��55       �� TextWrapping$
 Wrap=�6+   $	��155��6�   $��Times New Roman)�6�   $��16(�6�   $
��Bold"�6�   $��Italic$�6�   $��25��6�   $��0,0,0,10q�6
  ��6?   �� *SelectedItem.Quantity+$	 	stockGrid��$ PropertyChanged=�6
  �� 56      -   5         ��Name$ cbxUnit��56      $	��156��6(   $��0,0,0,10q�64   $��25��6F   $��Times New Roman)�6R   $��16(�6o   $
��Bold"�6}   $��Italic$�6�   $ Content��6�    6�   �� *SelectedUnit+$ PropertyChanged=�.@�57      �� $	��buc��6   $��Times New Roman)�6.   $��14(�6K   $
��Bold"�6Y   �� 58      $��kg��6   $��Times New Roman)�6-   $��14(�6J   $
��Bold"�6X   �� 59      $��l��6   $��Times New Roman)�6,   $��14(�6I   $
��Bold"�6W   5:      (  "System.Windows.Controls.DatePicker  5;      -   5          Name$ 
supplyDate��5;      $	��155��6�      Text 6-   �� *SelectedItem.SupplyDate+$	 	stockGrid��$ PropertyChanged=�6�     5<      -   5        $ expirationDate��5<      $	��155��6�   $��0,10,0,0q�6�    62   �� *SelectedItem.ExpirationDate+$	 	stockGrid��$ PropertyChanged=�6�   �� 5=      -   5        $ txtPurchasePrice��5=      $
 Wrap=�60   $	��156��6�   $��Times New Roman)�6�   $��16(�6�   $
��Bold"�6�   $��Italic$�6�   $��25��6	  $��	0,10,0,20q�6  ��6D   �� *SelectedItem.PurchasePrice+$	 	stockGrid��$ PropertyChanged=�6  �� 5>      -   5        $ txtSellingPrice��5>      $
 Wrap=�6/   $	��156��6�   $��Times New Roman)�6�   $��16(�6�   $
��Bold"�6�   $��Italic$�6�   $��25��6  $��	0,-10,0,0q�6  ��6C   �� *SelectedItem.SellingPrice+$	 	stockGrid��$ PropertyChanged=�6  5?      &   System.Windows.Controls.DataGrid  5@   
   -   5        $��	stockGrid��5@      $��
5,309,5,15q�6$   $��16(�68   $��Times New Roman)�6F   $
��Bold"�6d   $��Italic$�6v      AutoGenerateColumns .  $��Visible=�6�   ��6�   �� *	StockList+*  $Microsoft.Xaml.Behaviors.Interaction   	Behaviors 5A      7   1SupermarketProject.Exceptions.UpdateStockCombobox  5B         Columns 5D      0  *System.Windows.Controls.DataGridTextColumn  5E      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5	  /System.Windows.Controls.DataGridLengthConverter$ 30	 6N      FontSize$ 16Q�6Y      
FontFamily$ Times New Roman)�6g      
FontWeight$
 Bold"�6�      	FontStyle$ Italic$�6�   1
  +System.Windows.Controls.DataGridBoundColumn 
  Binding 61   �� *	StockID+6�     5F      $ Product Name��6%   $	 160	 6]   $ 16Q�6i   $ Times New Roman)�6w   $
 Bold"�6�   $ Italic$�6�    6;   �� *Product.Name+6�     5G      $ Quantity��6%   $ 80	 6U   $ 16Q�6`   $ Times New Roman)�6n   $
 Bold"�6�   $ Italic$�6�    67   �� *
Quantity+6�     5H      $
 Unit��6%   $ 50	 6L   $ 16Q�6W   $ Times New Roman)�6e   $
 Bold"�6�   $ Italic$�6�    63   �� *Unit+6�     5I      $ 
SupplyDate��6%   $	 100	 6y   $ 16Q�6�   $ Times New Roman)�6�   $
 Bold"�6�   $ Italic$�6�    69   �� *
SupplyDate+ �� StringFormat$ {0:dd-MM-yyyy}��6�     5J      $ ExipirationDate��6%   $	 120	 6�   $ 16Q�6�   $ Times New Roman)�6�   $
 Bold"�6�   $ Italic$�6�    6>   �� *ExpirationDate+$ {0:dd-MM-yyyy}��6�     5K      $ PurchasePrice��6%   $	 100	 6_   $ 16Q�6k   $ Times New Roman)�6y   $
 Bold"�6�   $ Italic$�6�    6<   �� *PurchasePrice+6�     5L      $ SellingPrice��6%   $	 100	 6]   $ 16Q�6i   $ Times New Roman)�6w   $
 Bold"�6�   $ Italic$�6�    6;   �� *SellingPrice+6�   5N      �� 5O   
   $
��Left=�6   $��430,274,0,0q�6/   $
��Wrap=�6D   $	��Top=�6v   $	��344��6�   $��20��6�   ���	#FFFC0F0F��6X   �� *ErrorMessage+6�   �� 5P   
   $
��Left=�6   $��4,4,0,0q�6/   $
��Wrap=�6@   $��STOCK��6T   $	��Top=�6a   $��30(�6y   $��Times New Roman)�6�   $
��Bold"�6�   $��Italic$�6�   5Q      5R      