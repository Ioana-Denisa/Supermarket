   M S B A M L   `   `   `  ����M  ISupermarketProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SupermarketProject.ViewModelsSupermarketProject.ViewModels  5   	   $    SupermarketProject.Views.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:SupermarketProject.ViewModels     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Login��5	   	   $	��550��6   $	��800��6$    � DataContext 5
      +   %SupermarketProject.ViewModels.LoginVM  5   
   .��5      � ��5   
   �� 5       �� ImageSource$g aC:\Users\Ioana\Desktop\Supermarket project\SupermarketProject\SupermarketProject\Images\login.png��6    j� 
AlignmentX$
 Left=�6�    j� 
AlignmentY$	 Top=�6�   .+�5   
   � $��320,239,115,65q�6   .+�5      �� $
��Left=�60   $��	119,0,0,0q�6K    �� TextWrapping$
 Wrap=�6^   $	��Top=�6s   $	��200��6�   $��30��6�   ���	#FF0D5FA5$��Times New Roman)�6�   $��16(�6�   $
��Bold"�6�   ��6   �� *
Username+6�   �� 5      $
��Left=�6   $��0,2,0,0q�63   $
��Wrap=�6D   $��Username��6X   $	��Top=�6h   ���	#FF0D5FA5$��Times New Roman)�6�   $��22(�6�   $
��Bold"�6�   $��Italic$�6�   �� 5      $
��Left=�6   $��0,50,0,0q�63   $
��Wrap=�6E   $��Password��6Y   $	��Top=�6i   ���	#FF0D5FA5$��Times New Roman)�6�   $��22(�6�   $
��Bold"�6�   $��Italic$�6�   �� 5      -   5         ��Name$ btnLogin��5      $��Login��6'   $
��Left=�67   $��119,160,0,0q�6R   $	��Top=�6g   
����������	#FF0D5FA5
�������$��Times New Roman)�6�   $��30(�6�   $��40��6�   $
��Bold"�6�   $��Italic$�6  $	��200��6  ��6%  �� *LoginCommand+�� 5      -   5         ��Name$ cbRole��5      $
��Left=�6'   $��119,100,0,0q�6B   $	��Top=�6W   $	��200��6o   $��30��6{   ���	#FF0D5FA5	 �� SelectedItem	 6�   �� *Type+.@�5      �� $��Administrator��6   $��Times New Roman)�68   $��14(�6U   $
��Bold"�6c   �� 5      $��Cashier��6   $��Times New Roman)�62   $��14(�6O   $
��Bold"�6]   5      �� 5      $
��Left=�6   $��0,90,0,0q�63   $
��Wrap=�6E   $
��Role��6Y   $	��Top=�6e   ���	#FF0D5FA5$��Times New Roman)�6�   $��22(�6�   $
��Bold"�6�   $��Italic$�6�   �� 5      $
��Left=�61   $��
119,50,0,0q�6L   $
 Wrap=�6`   $	��Top=�6u   $	��200��6�   $��30��6�   ���	#FF0D5FA5$��Times New Roman)�6�   $��16(�6�   $
��Bold"�6�   ��6   �� *
Password+6�   5      5      5       