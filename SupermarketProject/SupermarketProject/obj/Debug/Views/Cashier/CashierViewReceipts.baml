   M S B A M L   `   `   `  ����M  ISupermarketProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SupermarketProject.ViewModelsSupermarketProject.ViewModels  5   	   :    4SupermarketProject.Views.Cashier.CashierViewReceipts   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:SupermarketProject.ViewModels     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ CashierViewReceipts��5	   	   $	��550��6%   $	��800��62    � DataContext 5
      9   3SupermarketProject.ViewModels.CashierViewReceiptsVM  5   
   .��5      � ���#7F5F7C.+�5   
   �� $��
20,10,0,10q�64   ��6   �� *
Receipts+��5      �� 5      .R�5      �� ���#C68FC0���#CCCCCC$��4q�6H    �� CornerRadius$ 20��6\   $
��Auto��6n   $	��700��6|   $��0,0,0,10q�6�   ._�5      � $��10q�6    � RowDefinitions 5      �� 5   "   $
��Auto �60   �� 5   "   $��* �60   �� 5   "   $
��Auto �60   .+�5      � $��0��6#    � ColumnDefinitions 5   "   �� 5   &   $��2* �67   �� 5   &   $��1* �67   �� 5   &   $��1* �67   .+�5    "   �� $��0��6,   $��Product Name��6<   $��Times New Roman)�6P   $��16(�6m   $
��Bold"�6{   $��Italic$�6�   $��10q�6�   �� 5!   "   $��1��6,   $��Quantity��6<   $��Times New Roman)�6L   $��16(�6i   $
��Bold"�6w   $��Italic$�6�   $��10q�6�   �� 5"   "   $��2��6,   $��Subtotal��6<   $��Times New Roman)�6L   $��16(�6i   $
��Bold"�6w   $��Italic$�6�   $��10q�6�   5#      �� 5&      $��1��6+   ��68   �� *ReceiptItems+��5'   "   �� 5(   &   .R�5)   *   �  5*   .   �� 5+   2   $��2* �6C   �� 5,   2   $��1* �6C   �� 5-   2   $��1* �6C   .+�5/   .   �� $��0��68   $��Times New Roman)�6f   $��16(�6�   $
��Bold"�6�   $��Italic$�6�   $��10q�6�   ��6H   �� *Product.Name+6�   �� 50   .   $��1��68   $��Times New Roman)�6b   $��16(�6   $
��Bold"�6�   $��Italic$�6�   $��10q�6�   ��6H   �� *
Quantity+6�   �� 51   .   $��2��68   $��Times New Roman)�6�   $��16(�6�   $
��Bold"�6�   $��Italic$�6�   $��10q�6�   ��6H   �� *
Subtotal+ �� StringFormat$ Subtotal: {0:C}��6�   52   +   53   '   55      �� 57      $��2��6(   $��Times New Roman)�6i   $��20(�6�   $
��Bold"�6�   $��Italic$�6�   $��Right=�6�   $��10q�6�   ��65   �� *Total+$ Total: {0:C}��6�   �� 58      $��2��6(   $��Times New Roman)�6p   $��20(�6�   $
��Bold"�6�   $��Italic$�6�   $
��Left=�6�   $��10q�6�   ��65   �� *
ReleseDate+$ {0:dd-MM-yyyy}��6�   �� 59      $��2��6(   $��Times New Roman)�6S   $��20(�6p   $
��Bold"�6~   $��Italic$�6�   $��Center=�6�   $��10q�6�   ��65   �� *Cashier.Name+6�   5:      5;      5<      5>      5?      5@      