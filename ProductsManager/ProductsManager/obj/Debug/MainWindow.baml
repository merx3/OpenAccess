   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections  5   	    ProductsManager    ProductsManager.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   Bcol2clr-namespace:System.Collections;assembly=mscorlib     5   	     � Title$  Products Manager��5   	   $��361.941��6"   $��722.015��63    � 	Resources 5      "   System.Collections.ArrayList   	RProducts��%�  &	          5   
     5	      ��5
      LHBananaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa��6g   ��5      	Fruit��6$   ��5      1.20~�6$   5        5      ��5      	Juice��6$   ��5      
Drinks��6%   ��5      2.99~�6$   5        5      ��5      	Bread��6$   ��5      Food��6#   ��5      1.00~�6$   5      5      5      .��5      �� $��0,0,0,0q�6   .+�5   
   �� #��[  6    �� Left$ 34��6<   
 �� Top$ 31��6M   $	��188��6]   $
��Auto��6j   $	��400��6w    �� View 5      �� 5      .P�5      ��  �� CellTemplate 5      �� 5       .R�5!   "   �� 6-   5"      5$      �� 5%      $
��Name��6%    �� Width$	 100��6X    �� DisplayMemberBinding 63   �� *[0]+6f   �� 5&      $��Category��6%   $	 100��6\    67   �� *[1]+6j   �� 5'      $��Price��6%   $	 100��6Y    64   �� *[2]+6g   �� 5(       5)      �� 5*      .R�5+   "   �� $
��Edit��6)   6:   5,      5.      5/      51      �� 52   
   $��Categories to view:��6   $	 518��6.   $ 31��6@    J� RenderTransformOrigin$ 0.229,-0.111&�6P   �� 53   
   #��[  6   $	 518��6;   $ 62��6M   $
��Auto��6]   $	��200��6k   $	��138��6{   $��0q�6�   ��54      �� 55      .R�56      �� 	 �� Orientation$	 
Horizontal=�6!   .+�57      �� $��Center=�6#   6@   �� 58      $��Center=�68   ��6    �� *[1]+6V   59      5:      ��5<      �� 5=      
 �� 
TargetType"
 ��6   .�5>      ��  �� Property � �� �� Value$ 2q�60   6<   5?      5A      �� 5B   
   $ 69��6   $	 243��6"   $��30��63   $��30��6>   .��5C      �� $��/imgs/refresh.png��6   $ 13.251,-0.015&�6/   6W   5D      �� 5E   
   $��New Product��6   $	 499��6'   $	 225��69   $	��100��6J   �� 5F   
   $	 499��6   $	 267��6#   $	��100��64   $��38��6@   .��5G      ��  �� TextAlignment$ Center=�6   $
��Auto��6/   Delete selected�� 6M   
products6b   5H      5I      5J      