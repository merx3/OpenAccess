   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5   	   I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections  5   	    ProductsManager$   ProductsManager.WPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5   	   Bcol2clr-namespace:System.Collections;assembly=mscorlib     5   	     � Title$  Products Manager��5   	   $	��550��6"   $	��800��6/    � 	Resources 5      "   System.Collections.ArrayList   	RProducts��%�  &	          5!   
     5#      ��5$      LHBananaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa��6g   ��5%      	Fruit��6$   ��5&      1.20~�6$   5'        5)      ��5*      	Juice��6$   ��5+      
Drinks��6%   ��5,      2.99~�6$   5-        5/      ��50      	Bread��6$   ��51      Food��6#   ��52      1.00~�6$   53      55      57      .��59      �� $
��Auto=�6   $
��Auto=�66   .��5;   
   � $��10q�6    � ColumnDefinitions 5=      �� 5>      $��3* �6#   $	��400��6.   �� 5?      $��* �6#   $	��200��6.    � RowDefinitions 5B      �� 5C      $��4* �6    $	��250��6,   �� 5D      $
��Auto �6    �� 5E      $
��Auto �6    .+�5I      �� -   5        $��ProductsList��5O      $��0��5J      $��0��5K      $��10q�5M      $	��300��5N      $
��Left=�5P      ��5L      ��  �� Path$ DisplayedProducts� �� Mode$ TwoWay=� �� View 5R      �� 5T      .P�5V      ��  �� CellTemplate 5W      �� 5X   "   .R�5Y   &   ��  d� 	IsChecked 6/   �� $ ToDelete�$ TwoWay=�6b   5Z   #   5\      �� 5^      $
��Name��6)   	 �� Width$
	 auto��6b   
 �� DisplayMemberBinding
 67   �� $
 Name�6b   �� 5_      $��Category��6)   $		 100��6o   
 6;   �� $ Category.Name�6o   �� 5`      $��Price��6)   $		 100��6d   
 68   �� $ Price�6d   �� 5b       5c      �� 5d   "   .R�5e   &   �� -   5        $
��Edit��5e   B   
 � Tag 6Q   �� $ Id�6k   5f   #   5h      5j      5n      �� 5p      $��1��5q      $��0��5r      $��Categories to view:��5s      $��10q�5t      �� 5v      $��1��5w      $��0��5x      $��10 40q�5z      $
��Auto��5{      $
��auto��5|      $��0q�5}      ��5y      �� $ ProductsCategories���5      �� 5�      .R�5�      ��  �� Orientation$ 
Horizontal=�6%   .+�5�      �� -   5        $��Center=�5�   '    5�   '   �� $ 
IsSelected�$ TwoWay=�5�      �� 5�      $��Center=�6B   ��6$   �� $
 Name�6`   5�      5�      ��5�      �� 5�       �� 
TargetType" ��6   .�5�      ��  �� Property � �� �� Value$ 2q�64   6@   5�      5�      �� 5�      -   5        $��0��5�      $��1��5�      $��20 10q�5�      $
��Left=�5�      $��40��5�      $��40��5�      .��5�      �� -   5        $��RefreshButtonImage��5�   =   $!��/Resources/imgs/refresh.png��6    J� RenderTransformOrigin$ .5,.5&�6W   z�5�      �� 5�      -   5        AnimatedRotateTransform�� �� Angle$ 0Q�5�   K    � Triggers 5�      :� 5�       :� RoutedEvent$ 
MouseEnter��6'   .[�5�      �� .��5�   "   �� .��5�   &   W�  �� 
TargetName$ AnimatedRotateTransform��66    �� TargetProperty$ Angle�5�   2   	 W� By$ 10X�5�   2   	 W� To$	 360X�5�   2    g� Duration$ 0:0:0.5D�5�   2    g� FillBehavior$
 Stop=�5�   2   5�   #   5�      5�      5�      5�      �� 5�      -   5        $��1��5�      $��1��5�      $��New Product��5�      $��10q�5�      $	��100��5�      5�      �� 5�      -   5        $��1��5�      $��2��5�      $��10q�5�      $	��100��5�      $��40��5�      .��5�      ��  �� TextAlignment$ Center=�6   $
��Auto��63   Delete selected�� 6R   
products6g   5�      5�      5�      5�      