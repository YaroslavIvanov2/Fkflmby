   M S B A M L   `   `   `  ����M  IDiplom_AladinSclad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:Diplom_AladinSclad.Pages.mainWindowPostavki+Diplom_AladinSclad.Pages.mainWindowPostavki  5   	   C    =Diplom_AladinSclad.Pages.mainWindowPostavki.WindowAddPostavka   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Klocal9clr-namespace:Diplom_AladinSclad.Pages.mainWindowPostavki     5   	     � Title$  FoodShef��5   	   $	��450��6   $	��294��6'   .��5	      � .+�5
   
   �� $
��Left=�6   $
��Wrap=�6/   $��Поставки��6C   $	��Top=�6S   $��
119,59,0,0q�6k   �� 5   
   $
��Left=�6   $
��Wrap=�6/   $!��Номер поставки��6C   $	��Top=�6Y   $��
21,110,0,0q�6q   �� 5   
   $
��Left=�6   $
��Wrap=�6/   $��Дата поставки��6C   $	��Top=�6X   $��
21,165,0,0q�6p   �� 5   
   $
��Left=�6   $
��Wrap=�6/   $��Поставщик��6C   $	��Top=�6T   $��
21,230,0,0q�6l   �� 5   
   $
��Left=�6   $
��Wrap=�6/   $��Товары��6C   $	��Top=�6Q   $��
21,278,0,0q�6i    J� RenderTransformOrigin$ 0.121,-3.571&�6}   �� 5   
   $
��Left=�6   $��23��6-    �� TextWrapping$
 Wrap=�69   $	��Top=�6j   $	��250��6�   $��
21,137,0,0q�6�   ��6M   �� *ID_Postavki+6�   �� 5   
   -   5         ��Name$ dishcombobox��5      $
��Left=�6)   $	��Top=�6D   $	��250��6\   $��
21,299,0,0q�6h   ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� ��6#   �� *Name+ d� 	IsChecked 6<   �� *	IsCheched+6^   �� 5       ��Name$ kolcombobox��6"   ��67   �� 6J   5      5      5      �� 5   
   -   5        $ postavshikbox��5       �� DisplayMemberPath$ Name_postavshika��6*   $
��Left=�6s   $	��Top=�6�   $	��250��6�   $��
21,251,0,0q�6�    �� SelectedItem 6O   �� *
Postavshik+6�   (  "System.Windows.Controls.DatePicker  5   
   $
��Left=�64   $	��Top=�6O   $��
21,186,0,0q�6g   $��39��6{   $	��250��6�   	   Text	 6   �� *Date_postavki+6�   �� 5   
   -   5        $��Сохранить��5   &   $
��Left=�6:   $	��Top=�6U   $��75��6m   $��
85,345,0,0q�6x   5      5      