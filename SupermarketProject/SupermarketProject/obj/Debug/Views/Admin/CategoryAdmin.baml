   M S B A M L   `   `   `  ����M  ISupermarketProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SupermarketProject.ViewModelsSupermarketProject.ViewModels  5   	   M+clr-namespace:SupermarketProject.ConvertersSupermarketProject.Converters  5   	   2    ,SupermarketProject.Views.Admin.CategoryAdmin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:SupermarketProject.ViewModels     5   	   FlocalConverter+clr-namespace:SupermarketProject.Converters     5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ Category��5
   	   $	��550��6   $	��800��6(    � DataContext 5      .   (SupermarketProject.ViewModels.CategoryVM  5   
   .��5      � ���#7F5F7C.+�5   
   �� $��Center=�6   $��0,84,0,0q�62    �� Orientation$ 
Horizontal=�6D   $	��Top=�6]   $	��800��6u   $��85��6�    � 	Resources 5      3   -SupermarketProject.Converters.CategoryConvert   categoryConvert��%   &	          5      61   5      .+�5      �� $	��Add��6   ���	#FFCCBFDC���	#FFAE82E2$��Times New Roman)�6R   $��25(�6o   $
��Bold"�6}   $��Italic$�6�   $��50��6�   $	��225��6�   $��	20,0,0,10q�6�   ��6�   �� *
AddCommand+��5      `� 5       `� 	Converter# [  6#   .1�5      ��  �� ElementName$ txtName��6"    �� Path$
 Text�68   5      5      �� 5      $��Update��6   ���	#FFCCBFDC���	#FFAE82E2$��Times New Roman)�6V   $��25(�6s   $
��Bold"�6�   $��Italic$�6�   $��50��6�   $	��225��6�   $��	30,0,0,10q�6�   ��6�   �� *UpdateCommand+��6�   �� $ categoriesGrid��$ SelectedItem��� 5      $��Delete��6   ���	#FFCCBFDC���	#FFAE82E2$��Times New Roman)�6U   $��25(�6r   $
��Bold"�6�   $��Italic$�6�   $��50��6�   $	��225��6�   $��	30,0,0,10q�6�   ��6�   �� *DeleteCommand+��6�   �� $ categoriesGrid��$ SelectedItem�5      �� 5   
   $
��Left=�6   $��185,184,0,0q�60   $ Vertical=�6E   $	��Top=�6\   $	��160��6t   $��50��6�   .+�5      �� $
��Wrap=�6   $
��Name��6,   $��	30,0,0,15q�68   $��Times New Roman)�6K   $��30(�6h   $
��Bold"�6v   $��Italic$�6�   5      �� 5    
   $��320,184,235,275q�6   .+�5!      �� -   5         ��Name$ txtName��5!      	 �� TextWrapping$
	 Wrap=�6'   $	��260��6�   $��Times New Roman)�6�   $��16(�6�   $
��Bold"�6�   $��Italic$�6�   $��40��6�   ��6;   �� *SelectedItem.Name+$ categoriesGrid��
 �� UpdateSourceTrigger$
 PropertyChanged=�6�   5"      &   System.Windows.Controls.DataGrid  5#   
   -   5        $��categoriesGrid��5#      $��140,294,165,15q�6)   $��20(�6A   $��Times New Roman)�6O   $
��Bold"�6m   $��Italic$�6      AutoGenerateColumns .  $��Visible=�6�   ��6�   �� *CategoryList+   Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6P      FontSize$ 16Q�6\      
FontFamily$ Times New Roman)�6j      
FontWeight$
 Bold"�6�      	FontStyle$ Italic$�6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *
CategoryID+6�     5&      $
 Name��6%   $	 150 6L   $ 16Q�6X   $ Times New Roman)�6f   $
 Bold"�6�   $ Italic$�6�    63   �� *Name+6�   5(      �� 5)   
   $
��Left=�6   $��225,249,0,0q�6/   $
��Wrap=�6D   $	��Top=�6v   $	��344��6�   $��20��6�   ���	#FFFC0F0F��6X   �� *ErrorMessage+6�   �� 5*   
   $
��Left=�6   $��	10,10,0,0q�60   $
��Wrap=�6C   $��CATEGORY��6W   $	��Top=�6g   $��Times New Roman)�6   $��30(�6�   $
��Bold"�6�   $��Italic$�6�   5,      5-      