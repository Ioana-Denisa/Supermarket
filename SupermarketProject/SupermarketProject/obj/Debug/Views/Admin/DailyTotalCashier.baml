   M S B A M L   `   `   `  ����M  ISupermarketProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SupermarketProject.ViewModelsSupermarketProject.ViewModels  5   	   6    0SupermarketProject.Views.Admin.DailyTotalCashier   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:SupermarketProject.ViewModels     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ DailyTotalCashier��5	   	   $	��550��6#   $	��800��60    � DataContext 5
      7   1SupermarketProject.ViewModels.DailyTotalCashierVM  5   
   .��5      � ���#7F5F7C.+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��	totalGrid��5      $��160,224,155,60q�6$   $��Times New Roman)�6<   $��20(�6Y   $
��Bold"�6g   $��Italic$�6y      AutoGenerateColumns .  $��Visible=�6�   ��6�   �� *DailyTotals+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 Day��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6k      FontSize$ 16Q�6w      
FontFamily$ Times New Roman)�6�   	   
FontWeight$
	 Bold"�6�   
   	FontStyle$
 Italic$�6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Day+ �� StringFormat$ {0:dd-MM-yyyy}��6�     5      $ Total��6%   $	 200 6N   $ 16Q�6Z   $ Times New Roman)�6h   $
	 Bold"�6�   $
 Italic$�6�    64   �� *Total+6�   5      �� 5   
   $
��Left=�6   $��235,184,0,0q�6/   $
��Wrap=�6D   $	��Top=�6v   $	��344��6�   $��20��6�   ���	#FFFC0F0F��6X   �� *ErrorMessage+6�   � 5   
   $
��Left=�6   $��73��6*   $��5,86,0,0q�66   $	��Top=�6H   $	��800��6`   .+�5      �� -   5         ��Name$ 
cbxCashier��5      $
��Left=�6+   $��
180,43,0,0q�6F   $	��Top=�6Z   $	��190��6r    �� DisplayMemberPath$
 Name��6�   $��35��6�   ��6~   �� *
Cashiers+ �� SelectedItem 6�   �� *SelectedUser+6�   �� 5      -   5        $ cbxYear��5      $
��Left=�6(   $��
420,41,0,0q�6C   $	��Top=�6W   $	��190��6o   $  ��6�   $��35��6�   ��6{   �� *Date+ 6�   �� *SelectedMonth+��5      �� 5      .R�5      �� ��6$   �� *.+$ {0:MMMM}��5      5      �� 5      $
��Left=�6   $
��Wrap=�63   $��Search Cashier��6G   $	��Top=�6]   $��Times New Roman)�6u   $��30(�6�   $
��Bold"�6�   $��Italic$�6�   $��	180,0,0,0q�6�   �� 5      $
��Left=�6   $��	420,0,0,0q�63   $
��Wrap=�6F   $��Search Months��6Z   $	��Top=�6o   $��Times New Roman)�6�   $��30(�6�   $
��Bold"�6�   $��Italic$�6�   5       �� 5!   
   $
��Left=�6   $��5,-4,0,0q�6/   $
��Wrap=�6A   $:��4The amount collected per day by a cashier per month.��6U   $	��Top=�6�   $��Times New Roman)�6�   $��30(�6�   $	��805��6�   $
��Bold"�6�   $��Italic$�6�   5"      5#      