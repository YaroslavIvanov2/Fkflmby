   M S B A M L   `   `   `  ����M  IDiplom_AladinSclad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Diplom_AladinScladDiplom_AladinSclad  5   	   *    $Diplom_AladinSclad.WindowGlavnoeMenu   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Diplom_AladinSclad     5   	     � Title$  WindowGlavnoeMenu��5   	   $	��450��6#   $	��800��60   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��200 �6   6-   �� 5      6!   .+�5   
   ]� $��0��6   ���#ebbe42.+�5      �� 
���   �$	��Top=�6,   $	��0,0q�6B   $��45��6O    �� Orientation$ 
Horizontal=�6[   .+�5      �� $��15,0,0,0q�6   $��40��6*   $��resources/images/logo.png��65   �� 5      $��20(�6   $��	15,10,0,9q�6*   
�������$��Center=�5      $��FoodShef��63   $
��Bold"�6C   $��95��6U   5      �� 5      $��Bottom=�6   $��60��61   $ 
Horizontal=�6=   ���#1c1a2f.+�5      �� $��7q�6   $��43��6$    �� CornerRadius$ 15��6/   ��5      �� 5       �� ImageSource$  Resources/Images/admin.png��6%   6P   5      �� 5      $��5,0,0,0q�6   $��95��6.   $ Vertical=�69   .+�5      �� $��Аладьин��6    $��12(�6/   
�������$��	0,15,10,0q�6P   $
��Bold"�6c   5      �� 5      $��Ярослав��6    
�������$��12(�6B   $��0,2,10,0q�6P   $
��Bold"�6b   6v   5      �� 5      -   5        $
��Exit��5      $��50��5    ,      buttonExitStyle#��[  67    J� RenderTransformOrigin$ 	0.2,0.517&�6`   5!      �� 5"        menuList#��[ 6   $��	0,20,0,20q�6l   $��0q�5#      
������ $	��Top=�6C   ��5"   E   �� *PageCollection+ �� SelectedItem 5$      �� *CurrentPage+��5%      �� 5&      .R�5'      �� 
���   �$
��Bold"�67   $��Center=�5(   $   $��Center=�6?   $��16(�6\   ��5)   $   �� *Title+6=   5*      5,      5-       � 5.   
     � NavigationUIVisibility$ Hidden=�6   $��1��6P   ��60   �� *CurrentPage+6b   5/      50      