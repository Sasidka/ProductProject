   M S B A M L   `   `   `  ����I  EProductPRoject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:ProductPRoject.Pages.Views.UserPages$ProductPRoject.Pages.Views.UserPages  5      3    -ProductPRoject.Pages.Views.UserPages.MainPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Dlocal2clr-namespace:ProductPRoject.Pages.Views.UserPages     5      -   5          N� Title$  MainPage��5      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      �� 5      $
��0.2* �6   .+�5   
   �� $
��Left=�6   $��Center=�5      .+�5      �� -   5         ��Name$ BackBtn��5      $��25��5      $	��100��5      $��
Выйти��5      $��10 0 0 0q�5      5      5      �� 5   
    �� Orientation$ 
Horizontal=�6   $
��Left=�5       $��Center=�5!      $��	280,0,0,0q�60   .+�5"      �� $��Поиск:��6   $��40��5#      �� 5$      -   5         ��Name$ 	SearchTxb��5$      $	��200��5%      $��20��5&      5'      5(      �� 5*   
   $��Right=�6   $��Center=�5+      .+�5,      �� -   5         ��Name$ FiltrCmb��5,      $	��120��5-       �� DisplayMemberPath$
 Name��5.      $��0 0 10 0q�5/      50      51      �� 55   
   -   5         ��Name$ 	ProductLV��55      $��1��56      ��57      �� 58      .R�59      �  � ColumnDefinitions 5:      �� 5;      �� 5<      .+�5>      �� $��0��6%   $��Center=�5?   %   .+�5@      �� $	��150��5A   $   $	��150��5B   $   ��5@   $   �� *Image+5B   $   5C      �� 5D      $��1��6%   $��Center=�5E   %   .+�5F      �� 	 �� ContentStringFormat$&	  Название ткани: {0}��69   ��6    �� *Name+69   �� 5G      $	 Ширина: {0}��6:   ��6    �� *Width+6:   �� 5H      $	 Длина: {0}��6;   ��6    �� *Lenght+6;   �� 5I      $	 Описание: {0}��6<   ��6    �� *	Comment+6<   5J      5K      5L      5N      �� 5Q   
   $��2��6   $ 
Horizontal=�5R      $
��Left=�5S      $��	195,0,0,0q�60   .+�5T      �� -   5        $ 	DeleteBtn��5T      $	��130��5U      $��30��5V      $��Удалить��5W      5X      �� 5Y      -   5        $ AddBtn��5Y      $	��130��5Z      $��30��5[      $
��10 0q�5\      $��Добавить��5]      5^      �� 5_      -   5        $ EditBtn��5_      $	��130��5`      $��30��5a      $ ��Редактировать��5b      5c      5d      5e      5f      