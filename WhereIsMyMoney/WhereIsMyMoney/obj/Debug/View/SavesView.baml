   M S B A M L   `   `   `  ����I  EWhereIsMyMoney, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WhereIsMyMoney.ViewWhereIsMyMoney.View  5      #    WhereIsMyMoney.View.SavesView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:WhereIsMyMoney.View     5      .��5      � 
�������  � ColumnDefinitions  5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��50 �6    � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $��60 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��* �6   �� 5       $��30 �6   �� 5!      $��40 �6   .+�5#   
   �� $��0��6   $��1��5$      $��32(�5%      $��3��5&      $��Center=�5'      $��Center=�5(      $
��Bold"�5)      .��6&   Saves6-   �� 5*   
   $��1��6   $��3��5+      $��24(�5,      $��Center=�5-      $��Center=�5.      $
��Bold"�5/      .��6&   
Outcomes60   �� 51   
   $��1��6   $��1��52      $��24(�53      $��Center=�54      $��Center=�55      $
��Bold"�56      .��6&   	Incomes6/   �� 58   
   $��2��6   $��1��59      $��6��5:      .@�5;      �� .��6   ListBox Item #16+   �� 5<      .��6   ListBox Item #26+   �� 5=      .��6   ListBox Item #36+   5>      &   System.Windows.Controls.DataGrid  5?   
   
��� d �
�������$
��auto��6f      AutoGenerateColumns .     
IsReadOnly . $��2��6�   $��1��6�   $��6��6�   ��6   ��  �� Path$ Incomes�   Columns 5@      0  *System.Windows.Controls.DataGridTextColumn  5A      ,  &System.Windows.Controls.DataGridColumn   Header$ Type of Income��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Type+  5B      $ For 'x' months��6%    6=   �� *
Duration+  5C      $ Monthly��6%    66   �� *Value+  5D      $ Total Amount��6%    6;   �� *Total+5F        5G   
   
���  ��
�������$
��auto��6e    .   . $��2��6�   $��3��6�   $��6��6�   ��6   �� $ Outcomes� 5H        5I      $ Type of Outcome��6%    6>   �� *Type+  5J      $ For 'x' months��6%    6=   �� *
Duration+  5K      $ Monthly��6%    66   �� *Value+  5L      $ Total Amount��6%    6;   �� *Total+5N      �� 5O   
   $��8��6   $��1��5P      $��3��5Q      .+�5R      �� $��Center=�6   $��24(�61   ��6?   �� $ MyMoney�5T      �� 5U   
   $��9��6   $��1��5V      $��3��5W      $��	Calculate��6)   ��6=   �� $ calculateCommand�5X      5Y      