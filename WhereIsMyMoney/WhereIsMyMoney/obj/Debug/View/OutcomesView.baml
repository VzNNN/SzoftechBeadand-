   M S B A M L   `   `   `  ����I  EWhereIsMyMoney, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WhereIsMyMoney.EnumsWhereIsMyMoney.Enums  5      &     WhereIsMyMoney.View.OutcomesView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:WhereIsMyMoney.Enums     5      .��5      � 
�������  � ColumnDefinitions  5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��50 �6    � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $��60 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��* �6   �� 5       $��30 �6   �� 5!      $��40 �6   .+�5#   
   �� $��0��6   $��1��5$      $��32(�5%      $��3��5&      $��Center=�5'      $��Center=�5(      $
��Bold"�5)      .��6&   
Outcomes60   �� 5*   
   $��3��6   $��1��5+      ��6"   ��  �� Path$ CurrentOutcome.Value� �� Mode$ TwoWay=��� 5,   
   $��2��6   $��1��5-      $
��Bold"�5.      .��6&   Value:6.   �� 5/   
   $��5��6   $��1��50       �� SelectedIndex$ 0��6#    �� SelectedItem 65   �� $ CurrentOutcome.Type�$ TwoWay=���51      ��  �� Source 0   *WhereIsMyMoney.Enums.BindingEnumsExtension  *M� *local:OutcomesType++52      �� 53   
   $��4��6   $��1��54      $
��Bold"�55      .��6&   Type:6-   �� 56   
    �� Orientation$ Vertical=�6   $��10q�57      $��8��58      $��1��59      .+�5:      �� $
��Bold"�6   .��6&   Duration in months:6;   �� 5;      $ Vertical=�6   .+�5<      �� -   5        $��slValue��5<   |    � Minimum$ 1Q�6   	 � Maximum$	 12Q�6&   
 �� IsSnapToTickEnabled
 .  �� TickPlacement$ BottomRight=�6N    �� TickFrequency$ 1Q�6j    � Value 6�   �� $ CurrentOutcome.Duration�$ TwoWay=��� 5=       �� TextAlignment$ Right=�6p   $��20��6�   ��6   ��  �� ElementName$ slValue��$ Value� �� UpdateSourceTrigger$ PropertyChanged=�6�   5>      5?      �� 5@   
   -   5         ��Name$ 
bttnSubmit��5@      $��Add Outcomes��5A      $��1��5B      $��9��5C      ��6   �� $ 
addCommand�5E      �� 5F   
   -   5         ��Name$ Message��5F      $��1��6!   $��10��61   ��6?   �� $ Message�&   System.Windows.Controls.DataGrid  5G   
   
���   �
�������$
��auto��6c      AutoGenerateColumns .     
IsReadOnly . $��2��6�   $��3��6�   $��7��6�   ��6   �� $ Outcomes�   Columns 5H      0  *System.Windows.Controls.DataGridTextColumn  5I      ,  &System.Windows.Controls.DataGridColumn   Header$ Type of Outcome��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *Type+  5J      $ For 'x' months��6%    6=   �� *
Duration+  5K      $ Monthly��6%    66   �� *Value+5M      5O      5P      