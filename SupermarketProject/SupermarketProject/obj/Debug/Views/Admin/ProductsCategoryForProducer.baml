   M S B A M L   `   `   `  ����M  ISupermarketProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SupermarketProject.ViewModelsSupermarketProject.ViewModels  5   	   @    :SupermarketProject.Views.Admin.ProductsCategoryForProducer   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:SupermarketProject.ViewModels     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$! ProductsCategoryForProducer��5	   	   $	��550��6-   $	��800��6:    � DataContext 5
      A   ;SupermarketProject.ViewModels.ProductsCategoryForProducerVM  5   
   .��5      � ���#7F5F7C.+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��productGrid��5      $��75,249,20,35q�6&      AutoGenerateColumns .  $��Visible=�6Y   $��20(�6�   $��Times New Roman)�6�   $
��Bold"�6  $��Italic$�6  ��6�   �� *
Products+ �� SelectedItem 6�   �� *SelectedProduct+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 40 6P      FontSize$ 16Q�6[   	   
FontFamily$	 Times New Roman)�6i   
   
FontWeight$

 Bold"�6�      	FontStyle$ Italic$�6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *	ProductID+6�     5      $
 Name��6%   $	 140 6M   $ 16Q�6Y   $	 Times New Roman)�6g   $

 Bold"�6�   $ Italic$�6�    63   �� *Name+6�     5      $ Barcode��6%   $	 140 6R   $ 16Q�6^   $	 Times New Roman)�6l   $

 Bold"�6�   $ Italic$�6�    66   �� *	Barcode+6�   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Category��6)   $	 140 6;      CellTemplate 5      �� 5      .R�5      �� $��40��6H   $��16(�6S   $��Times New Roman)�6a   $
��Bold"�6   $��Italic$�6�   ��6(   �� *Category.Name+6�   5      5        5      $ Producer��6)   $	 140 6;    5      �� 5      .R�5      �� $��70��6G   $��16(�6R   $��Times New Roman)�6`   $
��Bold"�6~   ��6(   �� *Producer.Name+6~   5      5       5"      �� 5#   
   $
��Left=�6   $��235,209,0,0q�6/   $
��Wrap=�6D   $	��Top=�6v   $	��344��6�   $��20��6�   ���	#FFFC0F0F��6X   �� *ErrorMessage+6�   � 5$   
   $��Center=�6   $	��103��6,   $��0,91,0,0q�69   $	��Top=�6K   $	��800��6c   .+�5%      �� -   5         ��Name$ cbxProducers��5%      $
��Left=�6-   $��
105,41,0,0q�6H   $	��Top=�6\   $	��200��6t    �� DisplayMemberPath$
 Name��6�   $��30��6�   ��6�   �� *	Producers+ 6�   �� *SelectedProducer+6�   �� 5&      -   5        $ cbxCategory��5&      $
��Left=�6,   $��
425,41,0,0q�6G   $	��Top=�6[   $	��200��6s   $
 Name��6�   $��30��6�   ��6   �� *
Categories+ 6�   �� *SelectedCategory+6�   �� 5'      $
��Left=�6   $
��Wrap=�63   $��
105,00,0,0q�6G   $��Search Producer��6[   $	��Top=�6r   $��Times New Roman)�6�   $��26(�6�   $
��Bold"�6�   $��Italic$�6�   �� 5(      $
��Left=�6   $��	418,0,0,0q�63   $
��Wrap=�6F   $��Search Category��6Z   $	��Top=�6q   $��Times New Roman)�6�   $��26(�6�   $
��Bold"�6�   $��Italic$�6�   5*      �� 5+   
   $
��Left=�6   $��	11,14,0,0q�6/   $
��Wrap=�6B   $��SEARCH PRODUCT��6V   $	��Top=�6l   $��Times New Roman)�6�   $��30(�6�   $
��Bold"�6�   $��Italic$�6�   5-      5.      