   M S B A M L   `   `   `  ����M  ISupermarketProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SupermarketProject.ViewModelsSupermarketProject.ViewModels  5   	   0    *SupermarketProject.Views.Admin.MoreOptions   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:SupermarketProject.ViewModels     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ MoreOptions��5	   	   $	��550��6   $	��800��6*    � DataContext 5
      3   -SupermarketProject.ViewModels.AdministratorVM  5   
   .��5      � .+�5   
   �� $��15,64,10,-30q�6   .+�5      �� $3��-Display products and categories for producers��6   $��Times New Roman)�6M   $��30(�6j   $
��Bold"�6x   $��Italic$�6�   ���	#FF758F57$	��700��6�   
�������$��	0,10,0,10q�6�   $��70��6�   ��6�   Z� ��6
  �� *ProductCategory+�� 5      $��Total price per category��6   $��Times New Roman)�68   $��30(�6U   $
��Bold"�6c   $��Italic$�6u   ���	#FF758F57$	��700��6�   
�������$��0,0,0,10q�6�   $��70��6�   ��6�   Z� ��6�   �� *CategoryTotalPriceCommand+�� 5      $ ��Cashier details per month ��6   $��Times New Roman)�6:   $��30(�6W   $
��Bold"�6e   $��Italic$�6w   ���	#FF758F57$	��700��6�   
�������$��0,0,0,10q�6�   $��70��6�   ��6�   Z� ��6�   �� *DailyTotalCashier+�� 5      $��Largest Receipt��6   $��Times New Roman)�6/   $��30(�6L   $
��Bold"�6Z   $��Italic$�6l   ���	#FF758F57$	��700��6�   
�������$��0,0,0,10q�6�   $��70��6�   ��6�   Z� ��6�   �� *LargestRecept+�� 5      $��View the receipts��6   $��Times New Roman)�61   $��30(�6N   $
��Bold"�6\   $��Italic$�6n   ���	#FF758F57$	��700��6�   
�������$��0,0,0,10q�6�   $��70��6�   ��6�   Z� ��6�   �� *ViewReceipts+5      5      5      