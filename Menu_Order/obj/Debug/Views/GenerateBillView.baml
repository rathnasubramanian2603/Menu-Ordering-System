   M S B A M L   `   `   `  ����E  AMenu_Order, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Menu_Order.ViewsMenu_Order.Views  5      '    !Menu_Order.Views.GenerateBillView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Menu_Order.Views     5      .��5	      � .+�5
   
   �� $��Center=�6   $��-81,0,-62,-102q�62   $	��443��6J   .+�5      �   � ColumnDefinitions  5      �� 5      $	��15* �6'   �� 5      $
��428* �6'   .+�5      �� -   5         ��Name$ OrderNumbers��5      $
��Left=�5      $	��Top=�62   $	��120��6J   $��83.789,10,0,0q�6V   $��1��6m   ��5   1   �� *OrderNumbers+ �� SelectedIndex 6V   �� *SelectedIndex+5   m   �� 5      -   5         ��Name$ GenerateBill��5      $��Generate��60   $
��Left=�6C   $	��Top=�6^   $��75��6v   $��222.789,10,0,0q�6�   $��1��6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ Orders��5      $
��Left=�6+   $	��Top=�5   *      
IsReadOnly .    AutoGenerateColumns .  ��. $	��119��5      $	��372��6$   $��7,62,0,0q�60   $��2��6B   ��5   F   �� *Orders+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6J   	   Header$	 	Item Name��6T   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6-   �� *
FoodName+6T     5      $ * 6J   $	 Quantity��6T   
 6-   �� *
Quantity+6T     5      $ * 6H   $	 Price��6R   
 6.   �� *Price+6R   5      �� 5      -   5         ��Name$ 
label_Copy��5      
���   �$��Total��6?   $
��Left=�6O   $	��Top=�6j   $��49,230,0,-15q�6�   $	��103��6�   $��1��6�   $
��Bold"�6�   $��16(�6�   �� 5      -   5        $ 	BillPrice��5      
��� ���$
��Left=�6]   $	��Top=�6x   $��157,230,0,-15q�6�   $��75��6�   $��1��6�   $
��Bold"�6�   $��16(�6�   ��6?   �� *	BillPrice+6�   �� 5      -   5        $ label1��5      $��
Order No: ��6(   $
��Left=�6=   $	��Top=�6X   $��73��6p   $��1��6{   $��5,8,0,0q�6�   5       5!      5"      5#      