   M S B A M L   `   `   `  ����I  ECalculator 2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Calculator_2._0Calculator_2._0  5   	        Calculator_2._0.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Calculator_2._0     5   	     � Title$  Calculator 2.0��5   	   $	��450��6    $	��300��6-   $	��300��69   $	��300��6I    � Icon$ Icons/icon.png��6X   .��5	      � ���#eae3e3 � RowDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��3* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��4��6   $��0q�6!   $��30��65   $��30��6@   $��Right=�6L   
������ .��6�   H6�   �� 5   
   -   5        $��ResultScreen��5   $    �� 
IsReadOnly . $��1��68   $��4��6E   $��Bottom=�6Y   $��Right=�6{   $��25(�6�   $
��Bold"�6�   ���#eae3e3$��0q�6�   �� 5   
   $��0q�6   $��1q�6%   $��2��60   .��6=   %6@   �� 5    
   -   5        $��
ClearEntry��5    j   $��0q�6   $��1q�6%   $��2��60   $��1��6=   .��6|   CE6�   �� 5!   
   -   5        $��Clear��5!   j   $��0q�6   $��1q�6%   $��2��60   $��2��6=   .��6w   C6z   �� 5"   
   -   5        $��	BackSpace��5"   h   $��0q�6   $��1q�6&   $��2��61   $��3��6>   .��5#      �� $��Icons\backspace.png��6   $��10q�61   5$      �� 5&   
   -   5        $��divide2onebtn��5&      $��0q�6D   $��1q�6X   $��3��6c   .��5-      �� �� 5.       K� Variants$ Superscript=�6   .�66   169    �� 5/      .�6   /6    �� 50      $ 	Subscript=�6   .�64   x67   51      56      �� 57   
   -   5        $	��SQR��57      $��0q�6.   $��1q�6B   $��3��6M   $��1��6Z   .��58      �� �� 59      $ 	Subscript=�6   .�64   X67    �� 5:      $ Superscript=�6   .�66   269   5;      5<      �� 5=   
   -   5        $
��SQRT��5=      $��0q�60   $��1q�6D   $��3��6O   $��2��6\   .��5>      �� $��Icons/sqrt.png��6   $��Uniform=�6,   5?      �� 5@   
   -   5        $��Divide��5@   p   $��0q�6   $��1q�6&   $��3��61   $��3��6>   .��5B      �  5C      �� 5D      �� 5E      �� 5F      .+�5I      �� $	��•��6   $��Center=�6%   $��	0,-10,0,0q�6B   �� 5K      $��1��6   $��15��6)   
���   �64   �� 5L      $��2��6   $	��•��6*   $��Center=�63   5N      5P      �� 5R   
   -	   5        $��seven��5R   �   $��0q�6   
�������$
��Bold"�6:   $��1q�6M   $��4��6X   .��6�   76�   �� 5S   
   -
   5        $��eight��5S   �   $��0q�6   
�������$
��Bold"�6:   $��1q�6L   $��4��6W   $��1��6d   .��6�   86�   �� 5T   
   -   5        $
��nine��5T   �   $��0q�6   
�������$
��Bold"�6:   $��1q�6L   $��4��6W   $��2��6d   .��6�   96�   �� 5U   
   -   5        $��Multiply��5U   }   $��15(�6   $��0q�6   $��1q�63   $��4��6>   $��3��6K   .��6�   x6�   �� 5W   
   -   5        $
��four��5W   �   $��0q�6   
�������$
��Bold"�6;   $��1q�6M   $��5��6X   .��6�   46�   �� 5X   
   -   5        $
��five��5X   �   $��0q�6   
�������$
��Bold"�6;   $��1q�6M   $��5��6X   $��1��6e   .��6�   56�   �� 5Y   
   -   5        $	��six��5Y   �   $��0q�6   
�������$
��Bold"�6;   $��1q�6M   $��5��6X   $��2��6e   .��6�   66�   �� 5Z   
   -   5        $��Minus��5Z   }   $��15(�6   $��0q�6   $��1q�63   $��5��6>   $��3��6K   .��6�   -6�   �� 5\   
   -   5        $	��one��5\   �   $��0q�6   
�������$
��Bold"�6;   $��1q�6M   $��6��6X   .��6�   16�   �� 5]   
   -   5        $	��two��5]   �   $��0q�6   
�������$
��Bold"�6;   $��1q�6M   $��6��6X   $��1��6e   .��6�   26�   �� 5^   
   -   5        $��three��5^   �   $��0q�6   
�������$
��Bold"�6;   $��1q�6M   $��6��6X   $��2��6e   .��6�   36�   �� 5_   
   -   5        $
��Plus��5_   }   $��15(�6   $��0q�6   $��1q�63   $��6��6>   $��3��6K   .��6�   +6�   �� 5a   
   -   5        $��signChangeBtn��5a      $��0q�6B   $��1q�6V   $��7��6a   .��5c      �  5d      �� 5e      �� 5f      �� 5g      .+�5k      �� $��5,0,0,10q�6   $��2��6&   $��+��6:   �� 5l      $��1��6   $��/��6$   �� 5m      $��	-10,0,0,0q�6   $��2��6'   $��-��67   5n      5t      �� 5u   
   -   5        $
��zero��5u   �   $��0q�6   
�������$
��Bold"�68   $��1q�6J   $��7��6U   $��1��6b   .��6�   06�   �� 5v   
   -   5        $��	seperator��5v   a   $��0q�6   $��1q�6%   $��7��60   $��2��6=   $
��Bold"�6O   .��6�   ,6�   �� 5w   
   -   5        $��Equal��5w   x   $��0q�6   ���#73a4ca$��1q�6:   $��7��6E   $��3��6R   .��6�   =6�   5x      5z      