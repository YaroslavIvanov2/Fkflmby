   M S B A M L   `   `   `  ����M  IDiplom_AladinSclad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:Diplom_AladinSclad.Pages.mainWindowPostavki+Diplom_AladinSclad.Pages.mainWindowPostavki  5      >    8Diplom_AladinSclad.Pages.mainWindowPostavki.PagePostavki   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Klocal9clr-namespace:Diplom_AladinSclad.Pages.mainWindowPostavki     5      -   5        $��window��5	        N� Title$  Поставки��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $��0.19* �6   �� 5      $��0.58* �6   �� 5      $
��0.2* �6    � RowDefinitions 5   
   �� 5      .+�5   
   �� $
��Left=�6   $��0��6/   $	��Top=�6<   $��25(�6T   $��5q�6b   ��6m   ��  �� ElementName$ window�� �� Path$ Title�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ spisokPostavok��5   #   $��1��6   $��0,50,0,0q�6;      CanUserAddRows .     AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Код поставки��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6;   �� *ID_Postavki+6]     5      $	 Дата поставки��6%   
 6<   �� *Date_postavki+6`     5      $	 Поставщик��6%   
 68   �� *Postavshik.Name_postavshika+6j   5      �� 5   
   $��0��6   .+�5      �� -   5         ��Name$ AddTovar��5      $��Добавить��6'   $��	5,50,10,5q�5       $��40��6(   $��14(�67   5!   .   �� 5"      -   5        $ 
RedacTovar��5"      $ ��Редактировать��6)   $��40��5#      $��5,5,10,5q�6$   $��14(�66   5$   0   �� 5%      -   5        $ DeletePostav��5%      $��Удалить��6+   $��14(�6=   $��5,5,10,5q�5&      $��40��6'   6S   5'       � 5(   
   -   5          �Name$ UserCardFrame��5(      $	��450��5)      $	��160��6    $��2��5*        � NavigationUIVisibility$ Hidden=�5+      5-      5.      