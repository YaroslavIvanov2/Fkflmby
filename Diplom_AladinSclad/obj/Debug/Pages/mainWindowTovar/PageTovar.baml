   M S B A M L   `   `   `  ����M  IDiplom_AladinSclad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:Diplom_AladinSclad.Pages.mainWindowTovar(Diplom_AladinSclad.Pages.mainWindowTovar  5      8    2Diplom_AladinSclad.Pages.mainWindowTovar.PageTovar   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Hlocal6clr-namespace:Diplom_AladinSclad.Pages.mainWindowTovar     5      -   5        $��window��5	        N� Title$  Товары��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $��0.18* �6   �� 5      $
��0.5* �6    � RowDefinitions 5   
   �� 5      .+�5   
   �� $
��Left=�6   $��0��6/   $	��Top=�6<   $��25(�6T   $��5q�6b   ��6m   ��  �� ElementName$ window�� �� Path$ Title�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	userTabel��5      $��1��5         AutoGenerateColumns .  $��0,50,0,0q�5   /      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Код товара��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 69   �� *
ID_Tovar+6X     5      $# Название товара��6%   	 6>   �� *Naimenovanie_tovara+6h     5      $% Категория товара��6%   	 6?   �� *Category_tovarov.Naimenovanie+6s     5      $ Срок годности��6%   	 6<   �� *Srok_godnosti+6`   5      �� 5   
   $��0��6   .+�5       �� -   5        
 ��Name$
 AddTovar��5    0   $��Comic Sans MS)�6   $��Добавить��6Y   $��5,50,5,5q�6l   $��14(�6~   6�   �� 5!      -   5        $
 
RedacTovar��5!   0   $��Comic Sans MS)�6   $ ��Редактировать��6]   $��5q�6u   $��14(�6�   6�   �� 5"      -   5        $
 DeleteTovar��5"   1   $��Comic Sans MS)�6   $��5q�6F   $��Удалить��6Q   $��14(�6}   6�   5#      �� 5$   
    �� Orientation$ Vertical=�6   $	��200��6,   $��	4,200,0,0q�68   $
��Left=�6K   .+�5%      9�  9� 
IsExpanded . $��Вид товара��6)   .��5&      ��  �� SelectionMode$ Extended=�6N   $��0q�5'      
������ ��5&      �� *SectionFilters+ �� Mode$ OneWay=���5(      �� 5)      .R�5*      �� -   5        ��5+   '   �� *Category_tovarov.Naimenovanie+ d� 	IsChecked 6Y   �� *	IsChecked+6{   5,      5.      5/      50      �� 51   
   -   5         ��Name$ 	SearchBox��51      $��1��6%   $��10,10,10,10q�65   $��30��6J   $	��Top=�52      $��16(�6*      SearchTextBoxStyle#��[  69   6g   53      54      