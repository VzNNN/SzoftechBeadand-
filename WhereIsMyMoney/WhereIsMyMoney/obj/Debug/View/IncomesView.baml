   M S B A M L   `   `   `  ����I  EWhereIsMyMoney, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WhereIsMyMoney.EnumsWhereIsMyMoney.Enums  5      %    WhereIsMyMoney.View.IncomesView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:WhereIsMyMoney.Enums     5      .��5      � 
�������  � ColumnDefinitions  5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��50 �6    � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $��60 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5       $��* �6   �� 5!      $��30 �6   �� 5"      $��40 �6   .+�5$   
   �� $��0��6   $��1��5%      $��32(�5&      $��3��5'      $��Center=�5(      $��Center=�5)      $
��Bold"�5*      .��6&   	Incomes6/   �� 5+   
   $��3��6   $��1��5,      ��5-      ��  �� Path$ CurrentIncome.Value� �� Mode$ TwoWay=��� 5.   
   $��2��6   $��1��5/      $
��Bold"�50      .��6&   Value:6.   �� 51   
   $��5��6   $��1��52       �� SelectedIndex$ 0��6#    �� SelectedItem 65   �� $ CurrentIncome.Type�$ TwoWay=���53      ��  �� Source 0   *WhereIsMyMoney.Enums.BindingEnumsExtension  *M� *local:IncomesType++55      �� 56   
   $��4��6   $��1��57      $
��Bold"�58      .��6&   Type:6-   �� 5:   
    �� Orientation$ Vertical=�6   $��10q�5;      $��8��5<      $��1��5=      .+�5>      �� $
��Bold"�6   .��6&   Duration in months:6;   �� 5?      $ Vertical=�6   .+�5@      �� -   5        $��slValue��5@   |    � Minimum$ 1Q�6   	 � Maximum$	 12Q�6&   
 �� IsSnapToTickEnabled
 .  �� TickPlacement$ BottomRight=�6N    �� TickFrequency$ 1Q�6j    � Value 6�   �� $ CurrentIncome.Duration�$ TwoWay=��� 5A       �� TextAlignment$ Right=�6p   $��20��6�   ��6   ��  �� ElementName$ slValue��$ Value� �� UpdateSourceTrigger$ PropertyChanged=�6�   5B      5C      �� 5D   
   -   5         ��Name$ 
bttnSubmit��5D      $��Add Incomes��5E      $��1��5F      $��9��5G      ��6   �� $ 
addCommand�5H      �� 5I   
   -   5         ��Name$ Message��5I      $��1��6!   $��10��61   ��6?   �� $ Message�&   System.Windows.Controls.DataGrid  5J   
   
���   �
�������$
��auto��6b      AutoGenerateColumns .     
IsReadOnly . $��2��6�   $��3��6�   $��7��6�   ��6   �� $ Incomes�   Columns 5K      0  *System.Windows.Controls.DataGridTextColumn  5L      ,  &System.Windows.Controls.DataGridColumn   Header$ Type of Income��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Type+  5M      $ For 'x' months��6%    6=   �� *
Duration+  5N      $ Monthly��6%    66   �� *Value+5P      5Q      5R      