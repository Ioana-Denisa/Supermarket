   M S B A M L   `   `   `  ����M  ISupermarketProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SupermarketProject.ViewModelsSupermarketProject.ViewModels  5   	   M+clr-namespace:SupermarketProject.ConvertersSupermarketProject.Converters  5   	   M+clr-namespace:SupermarketProject.ExceptionsSupermarketProject.Exceptions  5	   	   1    +SupermarketProject.Views.Admin.ProductAdmin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:SupermarketProject.ViewModels     5   	   FlocalConverter+clr-namespace:SupermarketProject.Converters     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	   <
Exceptions+clr-namespace:SupermarketProject.Exceptions  5	   	     � WindowStartupLocation$  CenterScreen=�5
   	    � Title$ ProductAdmin��5   	   $	��550��6   $	��800��6+    � DataContext 5      -   'SupermarketProject.ViewModels.ProductVM  5   
   .��5      � ���#7F5F7C.+�5   
   �� $
��Left=�6   $��
510,27,0,0q�60    �� Orientation$ 
Horizontal=�6D   $	��Top=�6]   $	��260��6u   $	��240��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�    � 	Resources 5      2   ,SupermarketProject.Converters.ProductConvert   productConvert��%   &	          5      60   5      z�5      V� 5      .~�5      �� �� 5       �� AngleX$ -0.233Q�6$   �� 5      T� 5       T� X$ -0.396Q�6)   5      .+�5      �� $	��Add��6   ���	#FFCCBFDC���	#FFAE82E2$��Times New Roman)�6R   $��20(�6o   $
��Bold"�6}   $��Italic$�6�   $��55��6�   $	��180��6�   $��20,-110,-35,0q�6�   ��6�   �� *
AddCommand+��5      `� 5       `� 	Converter# [  6#   .1�5       �� 	 �� ElementName$	 txtName��6"   
 �� Path$

 Text�68   �� 5!      $	 
txtBarcode��6"   $

 Text�6;   �� 5"      $	 cbxCategory��6"   $
 SelectedItem.CategoryID�6<   �� 5#      $	 cbxProducer��6"   $
 SelectedItem.ProducerID�6<   5$      5&      �� 5'      $��Update��6   ���	#FFCCBFDC���	#FFAE82E2$��Times New Roman)�6U   $��20(�6r   $
��Bold"�6�   $��Italic$�6�   $��55��6�   $	��180��6�   $��-145,10,10,0q�6�   ��6�   �� *UpdateCommand+��6�   �� $	 productGrid��$
 SelectedItem��� 5(      $��Delete��6   ���	#FFCCBFDC���	#FFAE82E2$��Times New Roman)�6U   $��20(�6r   $
��Bold"�6�   $��Italic$�6�   $��55��6�   $	��180��6�   $��-200,130,0,0q�6�   ��6�   �� *DeleteCommand+��6�   �� $	 productGrid��$
 SelectedItem�5)      �� 5*   
   $
��Left=�6   $��	65,89,0,0q�60   $ Vertical=�6C   $	��Top=�6Z   $	��160��6r   $	��205��6~   .+�5+      �� $
��Wrap=�6   $
��Name��6,   $��	30,0,0,16q�68   $��Times New Roman)�6K   $��20(�6h   $
��Bold"�6v   $��Italic$�6�   �� 5,      $
��Wrap=�6   $��Barcode��6,   $��	30,0,0,16q�6;   $��Times New Roman)�6N   $��20(�6k   $
��Bold"�6y   $��Italic$�6�   �� 5-      $
��Wrap=�6   $��Category��6,   $��	30,0,0,15q�6<   $��Times New Roman)�6O   $��20(�6l   $
��Bold"�6z   $��Italic$�6�   �� 5.      $
��Wrap=�6   $��Producer��6,   $��	30,0,0,15q�6<   $��Times New Roman)�6O   $��20(�6l   $
��Bold"�6z   $��Italic$�6�   5/      �� 50   
   $��155,84,375,280q�6   .+�51      �� -   5        $��txtName��51       �� TextWrapping$
 Wrap=�6%   $	��170��6z   $��Times New Roman)�6�   $��16(�6�   $
��Bold"�6�   $��Italic$�6�   $��30��6�   $��0,0,0,10q�6�   ��69   �� $	 productGrid��$
 SelectedItem.Name�6�   �� 52      -   5        $��
txtBarcode��52      $
 Wrap=�6(   $	��170��6�   $��Times New Roman)�6�   $��16(�6�   $
��Bold"�6�   $��Italic$�6�   $��30��6�   $��0,0,0,10q�6�   ��6<   �� $	 productGrid��$
 SelectedItem.Barcode�6�   �� 53      -   5         ��Name$ cbxCategory��53      $	��170��6,    �� DisplayMemberPath$
 Name��6]    �� SelectedValuePath$ ID��6v   $��30��6�   ��68   �� *CategoryList+ �� SelectedValue 6�   �� *SelectedProduct.CategoryID+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 54      -   5        $ cbxProducer��54      $	��170��6,   $
 Name��6]   $ ID��6v   $��30��6�   $��0,10,0,0q�6�   ��68   �� *ProducerList+ 6�   �� *SelectedProduct.ProducerID+$ PropertyChanged=�6�   55      &   System.Windows.Controls.DataGrid  56   
   -   5        $��productGrid��56      $��25,269,20,15q�6&   $��20(�6<   $��Times New Roman)�6J   $
��Bold"�6h   $��Italic$�6z      AutoGenerateColumns .  $��Visible=�6�   ��6�   �� *ProductList+ �� SelectedItem 6   �� *SelectedProduct+*  $Microsoft.Xaml.Behaviors.Interaction   	Behaviors 57      :   4SupermarketProject.Exceptions.UpdateProductsCombobox  58         Columns 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 40 6O      FontSize$ 16Q�6Z      
FontFamily$ Times New Roman)�6h      
FontWeight$
 Bold"�6�      	FontStyle$ Italic$�6�   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 61   �� *	ProductID+6�     5<      $
 Name��6%   $	 180 6L   $ 16Q�6X   $ Times New Roman)�6f   $
 Bold"�6�   $ Italic$�6�    63   �� *Name+6�     5=      $ Barcode��6%   $	 140 6R   $ 16Q�6^   $ Times New Roman)�6l   $
 Bold"�6�   $ Italic$�6�    66   �� *	Barcode+6�   4
  .System.Windows.Controls.DataGridTemplateColumn
  5>      $ Category��6)   $	 140 6;    
  CellTemplate 5?      �� 5@      .R�5A      �� $	��140��6G   $��16(�6S   $��Times New Roman)�6a   $
��Bold"�6   $��Italic$�6�   ��6(   �� *Category.Name+6�   5B       
  CellEditingTemplate 5D      �� 5E      .R�5F      �� $
 Name��5G   '   $ ID��5H   '   $��16(�5I   q   $��Times New Roman)�6   $
��Bold"�6�   $��Italic$�6�   ��5F   '   �� *DataContext.CategoryList+ �� RelativeSource ��  �� AncestorType$ WindowL� 5I   '   �� *
CategoryID+$ PropertyChanged=�6�   5J      5L      
  5M      $ Producer��6)   $	 140 6;    5N      �� 5O      .R�5P      �� $	��140��6G   $��16(�6S   $��Times New Roman)�6a   $
��Bold"�6   $��Italic$�6�   ��6(   �� *Producer.Name+6�   5Q       5S      �� 5T      .R�5U      �� $
 Name��5V   '   $ ID��5W   '   $��16(�5X   q   $��Times New Roman)�6   $
��Bold"�6�   $��Italic$�6�   ��5U   '   �� *DataContext.ProducerList+ �� $ WindowL� 5X   '   �� *
ProducerID+$ PropertyChanged=�6�   5Y      5[      5]      �� 5^   
   $
��Left=�6   $��
35,229,0,0q�6/   $
��Wrap=�6C   $	��Top=�6u   $	��344��6�   $��20��6�   ���	#FFFC0F0F��6W   �� *ErrorMessage+6�   �� 5_   
   $
��Left=�6   $��	13,10,0,0q�6/   $
��Wrap=�6B   $��PRODUCT��6V   $��30(�6e   $��Times New Roman)�6s   $
��Bold"�6�   $��Italic$�6�   $	��Top=�6�   5`      5a      