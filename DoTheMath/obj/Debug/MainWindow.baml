   M S B A M L   `   `   `  ����D  @DoTheMath, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:DoTheMath	DoTheMath  5   	       DoTheMath.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:DoTheMath     5   	   -   5          � Title$  
MainWindow��5	   	   $	��400��6   $	��400��6)    � 	Resources 5
       �� 
TargetType   	textStyle �� Property �� Value  textBoxStyle��%q  &	        &	 �     �� 5   
   " ��6   .�5      ��  � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5       � ��$ 30(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5       � ��$ 30(�6)   �� 5       � ��$ Center=�6;   6L   5      5      .��5      � -   5         �Name$
 Page��5       � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5       $��* �6   �� 5!      $��2* �6   .+�5#   
   ��  �� Orientation$ 
Horizontal=�6   $��Center=�6.   .+�5$      �� $��Image/clock_icon.png��6   $��40��62   $��40��6>   $��Center=�6I   $��Center=�6f   6�   �� 5%      $��  ��6   6$   �� 5&      -   5         ��Name$ Timer��5&   ;   #��[  6   $��Center=�6J   6j   5(      �� 5)   
   -   5        $ QuestionText��5)   !   $��1��6   #��[  6V   ��67   �� 	 �� Path$	 question�6{   �� 5*   
   $��2��6   $��=��6!   #��[  6*   6O   �� 5+   
   -   5        
 ��Name$
 
userAnswer��5+      #��[ 5,      $��3��69   $��40��6F   $	��200��6R   
���   �.��6r   ��5-      �� 5.      $	 subm_answer�6    �� Mode$ TwoWay=�6-    �� UpdateSourceTrigger$ PropertyChanged=�6;   50      .��51      52      �� 53   
   -   5        $ 
textNotify��53   ^   #��[  6   $��10(�67   $��4��6E   $��20��6R   6t   �� 54   
   -   5         ��Name$ Submit��54   X    �� 	IsDefault . $��Submit��6"   $��40��63   $��5��6?   $��10q�6L   6h   56      57      