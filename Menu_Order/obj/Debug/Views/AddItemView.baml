   M S B A M L   `   `   `  ����E  AMenu_Order, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Menu_Order.ViewsMenu_Order.Views  5      "    Menu_Order.Views.AddItemView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Menu_Order.Views     5        � 	Resources  5	         Visibility Converter �� 
TargetType �� Property �� Value��%n   &	        '��      �� 5
   
   6'   �� 5   
   " ��6   .�5      ��  � ��$ 0q�6(   5      5      .��5      � .+�5   
   ]� .+�5      �� $	��Top=�6   $	��150��6.   $	��300��6;   $��Center=�6G   .+�5      � $��10q�6    � ColumnDefinitions 5      �� 5      $
��Auto �6+   �� 5      $��* �6+    � RowDefinitions 5      �� 5      $
��Auto �6(   �� 5      $
��Auto �6(   �� 5      $��* �6(   .+�5       �� 
���   �$��
-1,0,205,0q�6/   $��2��6C   $
��Bold"�6W   .��6i   Item:6p   �� 5!      -   5        $
��Name��5"      
�������$	��0.1q�6>   $��1��6T   $��0,4,0,6q�6d   �� 5$      ���#111010$��	1,0,216,0q�61   $��1��6D   $��2��6Q   $
��Bold"�6e   .��6w   Price:6   �� 5%      -   5        $��Price��5&      
�������$	��0.1q�6?   $��1��6U   $��1��6b   $��0,4,0,6q�6r   �� 5(      ���#111010$��-3,0,3,0q�61   $��2��6C   $
��Bold"�6P   .��6b   Description:6p   �� 5)      -   5        $��Description��5*      $�� ��5)      
�������$	��0.1q�5*   E   $��1��6[   $��2��6k    �� AcceptsReturn . $��	0,5,0,-42q�5+   /   �� 5-      -   5        $��AddItem��5-   0   $��Add Item��6   $��19,88,168,-90q�5.      $��2��60   $��2��6=   �� 5/      -   5        $��
UpdateItem��50   /   $��Update Item��6   $��19,126,168,-128q�6A   $��2��6Z   $��2��6g   �� 52      -   5        $��	ClearItem��52   -   $��Clear��6   $��88,88,19,-90q�53      $��2��6/   $��1��6<   �� 54      -   5         ��Name$ status��54      
��� � �$��-3,150,-5,-149q�55   +   $��2��6C   $��Center=�6P   $��16(�56      $
��Bold"�6&   $��2��68   �� 57      -   5         ��Name$ 
DeleteItem��57      $��Delete Item��61   $
��Left=�58      $	��Top=�64   $	��105��6L   $��1��6X   $��101,125,0,-128q�6h   $��2��6�   $��25��6�   5:      5;      �� 5<      	 �� Orientation$	 Vertical=�6   $��Bottom=�60   $	��296��6H   .+�5=      &   System.Windows.Controls.DataGrid  -	   5        
  Name$
 Items��5=   2   
�������$��3,105q�6A      
IsReadOnly .    AutoGenerateColumns .  ��. $	��188��5?   <   ��5>   F   �� *Items+ �� SelectedIndex 6d   �� *SelectedIndex+   Columns 5@      0  *System.Windows.Controls.DataGridTextColumn  5A      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6J      Header$ 	Food Name��6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   �� *
FoodName+6T     5B      $ * 6M   $ Description��6W    6-   �� *Description+6W     5C      $ * 6I   $ Price��6S    6.   �� *fPrice+6S   5E      5F      5G      5H      5I      