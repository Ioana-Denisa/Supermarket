   M S B A M L   `   `   `  ����M  ISupermarketProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SupermarketProject.ViewModelsSupermarketProject.ViewModels  5   	   M+clr-namespace:SupermarketProject.ConvertersSupermarketProject.Converters  5   	   2    ,SupermarketProject.Views.Admin.ProducerAdmin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:SupermarketProject.ViewModels     5   	   FlocalConverter+clr-namespace:SupermarketProject.Converters     5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ Producer��5
   	   $	��550��6   $	��800��6'    � DataContext 5      .   (SupermarketProject.ViewModels.ProducerVM  5   
   .��5      � ���#7F5F7C.+�5   
   �� $
��Left=�6   $��0,63,0,0q�60    �� Orientation$ 
Horizontal=�6B   $	��Top=�6[   $	��805��6s   $��73��6    J� RenderTransformOrigin$ 0.5,0.5&�6�    � 	Resources 5      3   -SupermarketProject.Converters.ProducerConvert   producerConvert��%   &	          5      61   5      z�5      V� 5      .~�5      �� �� 5       �� AngleX$ -0.233Q�6$   �� 5      T� 5       T� X$ -0.396Q�6)   5      .+�5      �� $	��Add��6   ���	#FFCCBFDC���	#FFAE82E2$��Times New Roman)�6R   $��30(�6o   $
��Bold"�6}   $��Italic$�6�   $��50��6�   $	��220��6�   $��	25,0,50,0q�6�   ��6�   �� *
AddCommand+��5      `� 5       `� 	Converter# [  6#   .1�5      �� 	 �� ElementName$	 txtName��6"   
 �� Path$

 Text�68   �� 5      $	 
txtCountry��6"   $

 Text�6;   5       5"      �� 5#      $��Update��6   ���	#FFCCBFDC���	#FFAE82E2$��Times New Roman)�6U   $��30(�6r   $
��Bold"�6�   $��Italic$�6�   $��50��6�   $	��220��6�   $��0,0,50,0q�6�   ��6�   �� *UpdateCommand+��6�   �� $	 producerGrid��$
 SelectedItem��� 5$      $��Delete��6   ���	#FFCCBFDC���	#FFAE82E2$��Times New Roman)�6U   $��30(�6r   $��Italic$�6�   $��50��6�   $	��220��6�   $��0,0,0,0q�6�   $
��Bold"�6'  ��6�   �� *DeleteCommand+��6�   �� $	 producerGrid��$
 SelectedItem�6'  5%      �� 5&   
   $
��Left=�6   $��260,179,0,0q�60   $ Vertical=�6E   $	��Top=�6\   $	��160��6t   $	��205��6�   .+�5'      �� $
��Wrap=�6   $
��Name��6,   $��	25,0,0,10q�68   $��Times New Roman)�6K   $��25(�6h   $
��Bold"�6v   $��Italic$�6�   �� 5(      $
��Wrap=�6   $��Country��6,   $��	25,0,0,10q�6;   $��Times New Roman)�6N   $��25(�6k   $
��Bold"�6y   $��Italic$�6�   5)      �� 5*   
   $��375,179,155,185q�6   .+�5+      �� -   5        $��txtName��5+       �� TextWrapping$
 Wrap=�6%   $	��200��6{   $��Times New Roman)�6�   $��16(�6�   $
��Bold"�6�   $��Italic$�6�   $��30��6�   $��0,0,0,10q�6�   ��69   �� $	 producerGrid��$
 SelectedItem.Name�6�   �� 5,      -   5        $��
txtCountry��5,      $
 Wrap=�6(   $	��200��6�   $��Times New Roman)�6�   $��16(�6�   $
��Bold"�6�   $��Italic$�6�   $��30��6�   $��0,0,0,10q�6�   ��6<   �� $	 producerGrid��$
 SelectedItem.Country�6�   5-      &   System.Windows.Controls.DataGrid  5.   
   -   5        $��producerGrid��5.      $��160,264,165,20q�6'   $��20(�6?   $��Times New Roman)�6M   $
��Bold"�6k   $��Italic$�6}      AutoGenerateColumns .  $��Visible=�6�   ��6�   �� *ProducerList+   Columns 5/      0  *System.Windows.Controls.DataGridTextColumn  50      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6P      FontSize$ 16Q�6\      
FontFamily$ Times New Roman)�6j      
FontWeight$
 Bold"�6�      	FontStyle$ Italic$�6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *
ProducerID+6�     51      $
 Name��6%   $	 160 6L   $ 16Q�6X   $ Times New Roman)�6f   $
 Bold"�6�   $ Italic$�6�    63   �� *Name+6�     52      $ Country��6%   $	 160 6R   $ 16Q�6^   $ Times New Roman)�6l   $
 Bold"�6�   $ Italic$�6�    66   �� *	Country+6�   54      �� 55   
   $
��Left=�6   $��
26,149,0,0q�6/   $
��Wrap=�6C   $	��Top=�6u   $	��344��6�   $��20��6�   ���	#FFFC0F0F��6W   �� *ErrorMessage+6�   �� 56   
   $
��Left=�6   $��5,4,0,0q�6/   $
��Wrap=�6@   $��PRODUCER��6T   $	��Top=�6d   $��Times New Roman)�6|   $��30(�6�   $
��Bold"�6�   $��Italic$�6�   57      58      