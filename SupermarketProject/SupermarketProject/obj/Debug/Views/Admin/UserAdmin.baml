   M S B A M L   `   `   `  ����M  ISupermarketProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SupermarketProject.ViewModelsSupermarketProject.ViewModels  5   	   M+clr-namespace:SupermarketProject.ConvertersSupermarketProject.Converters  5   	   .    (SupermarketProject.Views.Admin.UserAdmin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:SupermarketProject.ViewModels     5   	   FlocalConverter+clr-namespace:SupermarketProject.Converters     5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ Administrator��5
   	   $	��550��6   $	��800��6,    � DataContext 5      *   $SupermarketProject.ViewModels.UserVM  5   
   .��5      � ���#7F5F7C.+�5   
   �� $��Center=�6   $��0,59,0,0q�62    �� Orientation$ 
Horizontal=�6D   $	��Top=�6]   $	��800��6u   $��85��6�    � 	Resources 5      /   )SupermarketProject.Converters.UserConvert   userConvert��%   &	          5      6-   5      .+�5      �� $	��Add��6   ���	#FFCCBFDC���	#FFAE82E2$��Times New Roman)�6R   $��25(�6o   $
��Bold"�6}   $��Italic$�6�   $��50��6�   $	��220��6�   $��	20,0,0,10q�6�   ��6�   �� *
AddCommand+��5      `� 5       `� 	Converter# [  6#   .1�5      ��  �� ElementName$ txtName��6"    �� Path$
 Text�68   �� 5      $ txtPassword��6"   $
 Text�6<   �� 5      $ txtType��6"   $
 Text�68   5      5      �� 5      $��Update��6   ���	#FFCCBFDC���	#FFAE82E2$��Times New Roman)�6V   $��25(�6s   $
��Bold"�6�   $��Italic$�6�   $��50��6�   $	��220��6�   $��	30,0,0,10q�6�   ��6�   �� *UpdateCommand+��6�   �� $ 	usersGrid��$ SelectedItem��� 5      $��Delete��6   ���	#FFCCBFDC���	#FFAE82E2$��Times New Roman)�6U   $��25(�6r   $
��Bold"�6�   $��Italic$�6�   $��50��6�   $	��220��6�   $��	30,0,0,10q�6�   ��6�   �� *DeleteCommand+��6�   �� $ 	usersGrid��$ SelectedItem�5      �� 5    
   $
��Left=�6   $��215,169,0,0q�60   $ Vertical=�6E   $	��Top=�6\   $	��160��6t   $	��125��6�   .+�5!      �� $
��Wrap=�6   $��Username��6,   $��	30,0,0,15q�6<   $��Times New Roman)�6O   $��20(�6l   $
��Bold"�6z   $��Italic$�6�   �� 5"      $
��Wrap=�6   $��Password��6,   $��	30,0,0,15q�6<   $��Times New Roman)�6O   $��20(�6l   $
��Bold"�6z   $��Italic$�6�   �� 5#      $
��Wrap=�6   $
��Role��6,   $��	30,0,0,10q�68   $��Times New Roman)�6K   $��20(�6h   $
��Bold"�6v   $��Italic$�6�   5%      �� 5&   
   $��320,164,234,225q�6   .+�5'      �� -   5        $��txtName��5'       �� TextWrapping$
 Wrap=�6%   $	��200��6�   $��Times New Roman)�6�   $��20(�6�   $
��Bold"�6�   $��Italic$�6�   $��30��6�   $��0,0,0,10q�6  ��69   �� $ 	usersGrid��$ SelectedItem.Name�	 �� UpdateSourceTrigger$	 PropertyChanged=�6  �� 5(      -   5        $��txtPassword��5(      $
 Wrap=�6)   $	��200��6�   $��Times New Roman)�6�   $��20(�6�   $
��Bold"�6�   $��Italic$�6�   $��30��6  $��0,0,0,10q�6  ��6=   �� $ 	usersGrid��$ SelectedItem.Password�$	 PropertyChanged=�6  �� 5)      -   5        $��txtType��5)      $
 Wrap=�6%   $	��200��6�   $��Times New Roman)�6�   $��20(�6�   $
��Bold"�6�   $��Italic$�6�   $��30��6�   $��0,0,0,10q�6  ��69   �� $ 	usersGrid��$ SelectedItem.Type�$	 PropertyChanged=�6  5+      &   System.Windows.Controls.DataGrid  5,   
   -   5        $��	usersGrid��5,      $��115,324,105,10q�6$   
   AutoGenerateColumns
 .  $��Times New Roman)�6X   $��20(�6u   $
��Bold"�6�   $��Italic$�6�   $��Visible=�6�   ��6�   �� *	UsersList+   Columns 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 40 6L      
FontFamily$ Times New Roman)�6W      FontSize$ 16Q�6t      
FontWeight$
 Bold"�6�      	FontStyle$ Italic$�6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *UserID+6�     5/      $ Username��6%   $	 130 6P   $ Times New Roman)�6\   $ 16Q�6y   $
 Bold"�6�   $ Italic$�6�    67   �� *Name+6�     50      $ Password��6%   $	 130 6T   $ Times New Roman)�6`   $ 16Q�6}   $
 Bold"�6�   $ Italic$�6�    67   �� *
Password+6�     51      $
 Role��6%   $	 130 6L   $ Times New Roman)�6X   $ 16Q�6u   $
 Bold"�6�   $ Italic$�6�    63   �� *Type+6�   53      �� 54   
   $
��Left=�6   $��230,289,0,0q�6/   $
��Wrap=�6D   $	��Top=�6v   $	��344��6�   $��20��6�   ���	#FFFC0F0F��6X   �� *ErrorMessage+6�   �� 55   
   $
��Left=�6   $��	17,14,0,0q�6/   $
��Wrap=�6B   $
��USER��6V   $	��Top=�6b   $��Times New Roman)�6z   $��30(�6�   $
��Bold"�6�   $��Italic$�6�   58      59      