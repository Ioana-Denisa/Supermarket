   M S B A M L   `   `   `  ����M  ISupermarketProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SupermarketProject.ViewModelsSupermarketProject.ViewModels  5   	   4    .SupermarketProject.Views.Cashier.CashierSearch   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:SupermarketProject.ViewModels     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ CashierSearch��5	   	   $	��550��6   $	��800��6,    � DataContext 5
      3   -SupermarketProject.ViewModels.CashierSearchVM  5   
   .��5      � ���#7F5F7C.+�5   
   �� $
��Left=�6   $��
445,34,0,0q�60    �� Orientation$ 
Horizontal=�6D   $	��Top=�6]   $	��260��6u   $	��240��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5       �� AngleX$ -0.233Q�6$   �� 5      T� 5       T� X$ -0.396Q�6)   5      .+�5      �� $��Search��6   ���	#FFCCBFDC���	#FFAE82E2$��Times New Roman)�6U   $��20(�6r   $
��Bold"�6�   $��Italic$�6�   $��50��6�   $	��145��6�   $��10,-110,0,0q�6�   ��6�   �� *SearchCommand+5      5      �� 5   
   $
��Left=�6   $��	39,69,0,0q�60   $ Vertical=�6C   $	��Top=�6Z   $	��165��6r   $	��265��6~   .+�5      �� $
��Wrap=�6   $��Product name��6,   $��	30,0,0,15q�6@   $��Times New Roman)�6S   $��18(�6p   $
��Bold"�6~   $��Italic$�6�   �� 5      $
��Wrap=�6   $��Barcode��6,   $��	30,0,0,15q�6;   $��Times New Roman)�6N   $��18(�6k   $
��Bold"�6y   $��Italic$�6�   �� 5      $
��Wrap=�6   $��Expiration date��6,   $��	30,0,0,15q�6C   $��Times New Roman)�6V   $��18(�6s   $
��Bold"�6�   $��Italic$�6�   �� 5      $
��Wrap=�6   $��Producer name��6,   $��	30,0,0,15q�6A   $��Times New Roman)�6T   $��18(�6q   $
��Bold"�6   $��Italic$�6�   �� 5      $
��Wrap=�6   $��Category name��6,   $��	30,0,0,15q�6A   $��Times New Roman)�6T   $��18(�6q   $
��Bold"�6   $��Italic$�6�   5       �� 5!   
   $��139,68,391,160q�6   .+�5"      �� -   5         ��Name$ txtProductName��5"       �� TextWrapping$
 Wrap=�6.   $	��155��6_   $��Times New Roman)�6k   $��16(�6�   $
��Bold"�6�   $��Italic$�6�   $��25��6�   $��0,0,0,10q�6�   ��6B   �� *ProductName+6�   �� 5#      -   5        $ 
txtBarcode��5#      $
 Wrap=�6*   $	��155��6W   $��Times New Roman)�6c   $��16(�6�   $
��Bold"�6�   $��Italic$�6�   $��25��6�   $��0,0,0,10q�6�   ��6>   �� *	Barcode+6�   (  "System.Windows.Controls.DatePicker  5$      -   5        	  Name$	 dpExpirationDate��5$      $	��155��6[   $��Times New Roman)�6g   $��16(�6�   $
��Bold"�6�   $��Italic$�6�   $��25��6�   $��0,0,0,10q�6�   
   SelectedDate
 63   �� *ExpirationDate+6�   �� 5%      -   5        $��cbxProducers��5%      $	��156��6+   $��0,0,0,10q�67   $��25��6I    �� DisplayMemberPath$
 Name��6w    �� SelectedValuePath$
 Name��6�   ��6U   �� *	Producers+ �� SelectedValue 6�   �� *ProducerName+ �� Mode$ TwoWay=��� 5&      -   5        $��cbxCategories��5&      $	��156��6,   $��0,0,0,10q�68   $��25��6J   $
 Name��6y   $
 Name��6�   ��6V   �� *
Categories+ 6�   �� *CategoryName+$ TwoWay=�5'      &   System.Windows.Controls.DataGrid  5(   
   -   5        $��	stockGrid��5(      $��10,309,15,15q�6$   $��Times New Roman)�6;   $��18(�6X   $
��Bold"�6f   $��Italic$�6x      AutoGenerateColumns .  $��Visible=�6�   ��6�   �� *ProductsList+   Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Header$ Product name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6\      
FontFamily$ Times New Roman)�6i      FontSize$ 16Q�6�      
FontWeight$
 Bold"�6�      	FontStyle$ Italic$�6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *ProductName+6�     5+      $ Barcode��6%   $	 100 6R   $ Times New Roman)�6^   $ 16Q�6{   $
 Bold"�6�   $ Italic$�6�    66   �� *	Barcode+6�     5,      $ Expiration date��6%   $	 140 6�   $ Times New Roman)�6�   $ 16Q�6�   $
 Bold"�6�   $ Italic$�6�    6>   �� *ExpirationDate+ �� StringFormat$ {0:dd-MM-yyyy}��6�     5-      $ Producer name��6%   $	 140 6]   $ Times New Roman)�6i   $ 16Q�6�   $
 Bold"�6�   $ Italic$�6�    6<   �� *ProducerName+6�     5.      $ Category name��6%   $	 140 6]   $ Times New Roman)�6j   $ 16Q�6�   $
 Bold"�6�   $ Italic$�6�    6<   �� *CategoryName+6�   50      �� 51   
   $
��Left=�6   $��435,274,0,0q�6/   $
��Wrap=�6D   $	��Top=�6v   $	��344��6�   $��20��6�   ���	#FFFC0F0F��6X   �� *ErrorMessage+6�   52      53      