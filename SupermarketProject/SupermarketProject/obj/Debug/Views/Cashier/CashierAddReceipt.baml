   M S B A M L   `   `   `  ����M  ISupermarketProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SupermarketProject.ViewModelsSupermarketProject.ViewModels  5   	   8    2SupermarketProject.Views.Cashier.CashierAddReceipt   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:SupermarketProject.ViewModels     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ CashierAddReceipt��5	   	   $	��550��6#   $	��800��60    � DataContext 5
      7   1SupermarketProject.ViewModels.CashierAddReceiptVM  5   
   .��5      � ���#7F5F7C.+�5   
   �� $��Add product for receipt��6   ���	#FFCCBFDC���	#FFAE82E2$��Times New Roman)�6b   $��20(�6   $
��Bold"�6�   $��Italic$�6�   $��480,24,60,438q�6�   ��6�   �� *AddProductCommand+6�   �� 5   
   $
��Left=�6   $��
-15,19,0,0q�60    �� Orientation$ Vertical=�6D   $	��Top=�6[   $	��270��6s   $	��120��6   .+�5      �� $
��Wrap=�6   $��Select cashier name��6,   $��	30,0,0,15q�6G   $��Times New Roman)�6Z   $��20(�6w   $
��Bold"�6�   $��Italic$�6�   �� 5      $
��Wrap=�6   $��Enter quantity��6,   $��	30,0,0,15q�6B   $��Times New Roman)�6U   $��20(�6r   $
��Bold"�6�   $��Italic$�6�   �� 5      $
��Wrap=�6   $��Select product��6,   $��	30,4,0,10q�6B   $��Times New Roman)�6U   $��20(�6r   $
��Bold"�6�   $��Italic$�6�   5      �� 5   
   $��180,14,360,364q�6   .+�5      ��  �� TextWrapping$
 Wrap=�6   $	��200��6E   $��Times New Roman)�6Q   $��16(�6n   $
��Bold"�6|   $��Italic$�6�   $��30��6�   $��0,0,0,0q�6�   ��6*   �� *
Username+6�   �� 5      -   5         ��Name$ txtQuantity��5      $
 Wrap=�6+   $	��200��6Y   $��Times New Roman)�6e   $��16(�6�   $
��Bold"�6�   $��Italic$�6�   $��30��6�   $��	0,10,0,10q�6�   ��6?   �� *
Quantity+6�   �� 5      -   5        $��cbxProducts��5      $	��200��6*   $��0,0,0,10q�66   $��30��6H    �� DisplayMemberPath$
 Name��6u   ��6T   �� *
Products+ �� SelectedItem 6�   �� *SelectedProduct+5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��	stockGrid��5      $��55,179,105,120q�6$   $��Times New Roman)�6<   $��20(�6Y   $
��Bold"�6g   $��Italic$�6y      AutoGenerateColumns .  $��Visible=�6�   ��6�   �� *ReceiptProducts+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 
Product ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 6:      
FontFamily$ Times New Roman)�6d      FontSize$ 16Q�6�      
FontWeight$
 Bold"�6�      	FontStyle$ Italic$�6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   �� *	ProductID+6�     5      $
 Product name��6%   $	 220 6;   $ Times New Roman)�6i   $ 16Q�6�   $
 Bold"�6�   $ Italic$�6�    6H   �� *Product.Name+6�     5      $
 Quantity��6%   $	 140 67   $ Times New Roman)�6`   $ 16Q�6}   $
 Bold"�6�   $ Italic$�6�    6C   �� *
Quantity+6�     5      $
 Subtotal��6%   $	 140 67   $ Times New Roman)�6y   $ 16Q�6�   $
 Bold"�6�   $ Italic$�6�    6C   �� *
Subtotal+ �� StringFormat$ {0:C}��6�   5       �� 5!   
   $
��Left=�6   $��
35,229,0,0q�6/   $
��Wrap=�6C   $	��Top=�6u   $	��344��6�   $��20��6�   ���	#FFFC0F0F��6W   �� *ErrorMessage+6�   �� 5"   
   $��Save RECEIPT��6   $
��Left=�6(   $��550,444,0,0q�6C   $	��Top=�6X   ���	#FFCCBFDC���	#FFAE82E2$��Times New Roman)�6�   $��20(�6�   $
��Bold"�6�   $��Italic$�6�   $��50��6�   $	��170��6�   ��6  �� *SaveReceiptCommand+�� 5#   
   $
��Left=�6   $��
66,444,0,0q�6/   $
��Wrap=�6C   $��TOTAL:��6W   $	��Top=�6e   $��Times New Roman)�6}   $��30(�6�   $
��Bold"�6�   $��Italic$�6�   �� 5$   
   $
��Left=�6   $��180,449,0,0q�6-   $��16(�6B   $��Times New Roman)�6Q   $
��Bold"�6n   $��Italic$�6�   $
 Wrap=�6�   $	��Top=�6�   $	��200��6�   $��30��6�   ��6�   �� *Total+$ {0:C}��5%      5&      