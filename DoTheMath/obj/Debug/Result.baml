   M S B A M L   `   `   `  ����D  @DoTheMath, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:DoTheMath	DoTheMath  5   	       DoTheMath.Result   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:DoTheMath     5   	   -   5          � Title$  Result��5	   	   $	��300��6   $	��300��6%    � 	Resources 5
       �� 
TargetType   	textStyle �� Property �� Value��%�   &	        �� 5   
   " ��6   .�5      ��  � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5       � ��$ 30(�6)   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��3* �6   �� 5      $��* �6   .+�5!   
   �� -   5         ��Name$ 
textResult��5!   7   #��[  6   6M   �� 5"   
   -   5         ��Name$ listExam��5"      $��1��6%    5#       �� Triggers	 �� Binding
 �� Value��%Y  '��       �� 5$      " ��6   .�5%      ��  � {� .  6B   �� 5&       � ��$ Center=�6C   6T    5'      �� 5(      	 6&   �� *score+
 15)      .a�5*      ��  � ��
 ����5+      5,      �� 5-      	 6&   �� *score+
 -16@   .a�5.      ��  � ��
 �����6P   5/      51      52      ��53      �� 54      .R�55      ��  �� Orientation$ 
Horizontal=�6!   $��Center=�6:   .+�56      �� ��6$   ��  �� Path$ question��� 57      $��=��6$   �� 58      ��6$   �� $ subm_answer�59      5<      5>      � 5?   
   $��2��6    � ColumnDefinitions 5@      �� 5A      �� 5B      .+�5D      �� -   5         ��Name$ newGame��5D   @   $	��100��6   $��30��6!   $��New Game��6-   6k   �� 5E      -   5        $
 Quit��5E   L   $��1��6   $	��100��6%   $��30��61   $
��Quit��6=   6q   5F      5G      5H      