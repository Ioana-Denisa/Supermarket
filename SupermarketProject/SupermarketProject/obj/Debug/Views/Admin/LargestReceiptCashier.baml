   M S B A M L   `   `   `  ����M  ISupermarketProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SupermarketProject.ViewModelsSupermarketProject.ViewModels  5   	   :    4SupermarketProject.Views.Admin.LargestReceiptCashier   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:SupermarketProject.ViewModels     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ LargestReceiptCashier��5	   	   $	��550��6'   $	��800��64    � DataContext 5
      4   .SupermarketProject.ViewModels.LargestReceiptVM  5   
   .��5      � ���#7F5F7C.+�5   
   &   System.Windows.Controls.Calendar  $
��Left=�6   $��	280,9,0,0q�6.   $	��Top=�6A   $	��200��6Y   $	��220��6f      SelectedDate 6r   �� *SelectedDate+ �� Mode$ TwoWay=��� 5   
   $��Search��6   $	��Top=�6=   $��55��6U   $��Times New Roman)�6a   $��40(�6~   $
��Bold"�6�   $��Italic$�6�   ���	#FF64145B���	#FFC68FC0$��105,189,110,0q�6�   ��6"   �� *Search+6�   �� 5   
   ���#C68FC0���#CCCCCC$��4q�6<    �� CornerRadius$ 20��6P   $
��Auto��6b   $��100,259,110,0q�6p   ._�5      � $��10q�6    � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $��* �6$   �� 5      $
��Auto �6$   .+�5      � $��0��6    � ColumnDefinitions 5      �� 5      $��1* �6+   �� 5      $��1* �6+   �� 5      $��2* �6+   �� 5      $��1* �6+   .+�5!      �� $��0��6    $��Quantity��60   $��Times New Roman)�6@   $��20(�6]   $
��Bold"�6k   $��Italic$�6}   $��10q�6�   �� 5"      $��1��6    $��X��60   $��Times New Roman)�69   $��20(�6V   $
��Bold"�6d   $��Italic$�6v   $��10q�6�   �� 5#      $��2��6    $��Product Name��60   $��Times New Roman)�6D   $��20(�6a   $
��Bold"�6o   $��Italic$�6�   $��10q�6�   �� 5$      $��3��6    $��Subtotal��60   $��Times New Roman)�6@   $��20(�6]   $
��Bold"�6k   $��Italic$�6}   $��10q�6�   5%      �� 5(      $��1��6   ��6,   �� *ReceiptProducts+��5)      �� 5*      .R�5+      �  5,   "   �� 5-   &   $��1* �67   �� 5.   &   $��1* �67   �� 5/   &   $��2* �67   �� 50   &   $��1* �67   .+�52   "   �� $��0��6,   $��Times New Roman)�6V   $��16(�6s   $
��Bold"�6�   $��Italic$�6�   $��10q�6�   ��6<   �� *
Quantity+6�   �� 53   "   $��1��6,   $��x��6<   $��Times New Roman)�6E   $��16(�6b   $
��Bold"�6p   $��Italic$�6�   $��10q�6�   �� 54   "   $��2��6,   $��Times New Roman)�6Z   $��16(�6w   $
��Bold"�6�   $��Italic$�6�   $��10q�6�   ��6<   �� *Product.Name+6�   �� 55   "   $��3��6,   $��Times New Roman)�6n   $��16(�6�   $
��Bold"�6�   $��Italic$�6�   $��10q�6�   ��6<   �� *
Subtotal+ �� StringFormat$ {0:C}��6�   56      57      59      �� 5<      $��2��6   $��Times New Roman)�6l   $��20(�6�   $
��Bold"�6�   $��Italic$�6�   $��Right=�6�   $��10q�6�   ��6)   �� *LargestReceipt.Total+$ Total: {0:C}��6�   �� 5=      $��2��6   $��Times New Roman)�6s   $��20(�6�   $
��Bold"�6�   $��Italic$�6�   $
��Left=�6�   $��10q�6�   ��6)   �� *LargestReceipt.ReleseDate+$ {0:dd/MM/yyyy}��6�   �� 5>      $��2��6   $��Times New Roman)�6s   $��20(�6�   $
��Bold"�6�   $��Italic$�6�   $��Center=�6�   $��10q�6�   ��6)   �� *LargestReceipt.Cashier.Name+$ Cashier: {0}��6�   5?      5@      �� 5A   
   
���  ��$��
20,500,0,0q�6C   ��6   �� *ErrorMessage+6C   5B      5C      