   M S B A M L   `   `   `  ����J  FProductsManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:ProductsManager.WPF.ViewModel.Converters(ProductsManager.WPF.ViewModel.Converters  5   	   '    !ProductsManager.WPF.ProductModify   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Hlocal6clr-namespace:ProductsManager.WPF.ViewModel.Converters     5   	     � Title$  ProductModify��5   	   $	��300��6   $	��500��6,    � 	Resources 5      C   =ProductsManager.WPF.ViewModel.Converters.BoolToIndexConverter   boolToIndexConverter��%   &	          5   
   6%   5	      .��5      �� $
��Auto=�5   	   $
��Auto=�5   	   .��5      � $
��auto��5   	   $
��auto��5   	   $	��250��5   	   $	��400��5   	   $��Stretch=�5   	   $��Stretch=�5   	    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��1.2* �6   �� 5      $
��1.5* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       �� 5!      �� 5"      .+�5%   
   �� $��0��6   $��0��6   $��Product id:��5&      $
��Left=�5'      $��5q�5(      $	��Top=�5)      �� 5+   
   -   5        $��ProductIdLabel��5/      $��0��5+      $��0��6   $
��Left=�5-      $��70 5 0 0q�5.      $	��Top=�50      ��5,      ��  �� Path$ ProductToModify.Id�50      �� 52      $��1��6   $��0��6!   $��_Name:��53      $
��Left=�54      $��5q�55      $	��Top=�56       �� Target 57      ��  �� ElementName$ TBName���� 59   
   -   5        $��TBName��5:      $��1��59      $��1��6   $
��Left=�5;      $��23��5<      $��5q�5=       �� TextWrapping$
 Wrap=�5>      $	��Top=�5@      $	��120��5A      ��5?      �� $ ProductToModify.Name� �� Mode$ TwoWay=�5A      �� 5C   
   -   5        $��LblNameError��5D      $��1��5C      $��2��6   $��Please enter a valid name��5E      
���<��$
��Left=�5G      $��5q�5H      $y�Hidden=�5I      $	��Top=�5J      �� 5L   
   $��2��6   $��0��6   $��_Price:��5M      $
��Left=�5N      $��5q�5O      $	��Top=�5P       5Q      �� $ TBPrice���� 5S   
   -   5        $��TBPrice��5T      $��2��5S      $��1��6   $
��Left=�5U      $��23��5V      $��5q�5W      $
 Wrap=�5X      $	��Top=�5Z      $	��120��5[      ��5Y      �� $ ProductToModify.Price�$ TwoWay=�5[      �� 5]   
   -   5        $��LblPriceError��5^      $��2��5]      $��2��6   $ ��Please enter a valid price��5_      
���<��$
��Left=�5a      $��5q�5b      $y�Hidden=�5c      $	��Top=�5d      �� 5f   
   $��3��6   $��0��6   $��Is _available:��5g      $
��Left=�5h      $��5q�5i      $	��Top=�5j       5k      �� $ CBAvailable���� 5m   
   -   5        $��CBAvailable��5n      $��3��5m      $��1��6    $
��Left=�5o      $��5q�5p      $	��Top=�5r      $	��120��5s      	 �� SelectedValuePath	 5q      �� *IsAvailable+$ TwoWay=�
 �� 	Converter#
 [  .@�5t      ��  �� 
IsSelected . .��61   Yes66   �� 5u      .��6   No6#   5v      �� 5x   
   $��4��6   $��0��6   $��	Category:��5y      $
��Left=�5z      $��5q�5{      $	��Top=�5|       5}      �� $ 
CBCategory���� 5   
   -   5        $��
CBCategory��5�      $��4��5      $��1��6     �� 
IsEditable .  $
��Left=�5�      $��5q�5�       �� DisplayMemberPath$
 Name��5�      $	��Top=�5�      $	��120��6%   ��5�      �� $ AllCategories� �� SelectedItem 5�      �� $ ProductToModify.Category�$ TwoWay=�5�      �� 5�   
   -   5        $��LblCategoryError��5�      $��4��5�      $��2��6   $��Please choose a category��5�      
���<��$
��Left=�5�      $��5q�5�      $y�Hidden=�5�      $	��Top=�5�      �� 5�   
   -	   5        $��5��5�      $��2��6   $
��Save��5�      $
��Left=�5�      $��5q�5�      $	��Top=�5�      $��75��5�      5�      �� 5�   
   -
   5        $��5��5�      $��2��6   $��Cancel��5�      $
��Left=�5�      $��	100 5 0 0q�5�      $	��Top=�5�      $��75��5�      5�      5�      5�      5�      