   M S B A M L   `   `   `  ����I  EProductPRoject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:ProductPRoject.Pages.Views.UserPages$ProductPRoject.Pages.Views.UserPages  5      6    0ProductPRoject.Pages.Views.UserPages.AddEditPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Dlocal2clr-namespace:ProductPRoject.Pages.Views.UserPages     5        N� Title$  AddEditPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      �� 5      $
��0.2* �6   .+�5   
   �� $
��Left=�6   $��Center=�5      .+�5      �� -   5         ��Name$ BackBtn��5      $	��120��5      $��25��5      $��
Назад��5      $��10 10q�5      5       5!      �� 5$   
   $��Center=�6   $��Center=�5%      $��3��5&      .+�5'   
   ��  �� Orientation$ 
Horizontal=�6   .+�5(      �� $"��Название ткани:��6   $	��100��5)      �� 5*      -   5         ��Name$ ProductNameTb��5*      $	��150��5+      $��20��5-      ��5,      �� *product.Name+5-      5.      �� 50   
   $ 
Horizontal=�6   $��	0 10 0 10q�51      .+�52      �� $��Ширина:��6   $	��100��53      �� 54      -   5        $ ProductWidthTb��54      $	��150��55      $��20��57      ��56      �� *product.Width+57      58      �� 5:      $ 
Horizontal=�6   $��0 0 0 10q�5;      .+�5<      �� $"��Название ткани:��6   $	��100��5=      �� 5>      -   5        $ ProductLenghtTb��5>      $	��150��5?      $��20��5A      ��5@      �� *product.Lenght+5A      5B      �� 5D      $ 
Horizontal=�6   .+�5E      �� $"��Название ткани:��6   $	��100��5F      �� 5G      -   5        $ ProductCommentTb��5G      $	��150��5H      $��20��5J      ��5I      �� *product.Comment+5J      5K      �� 5L      $
��0 10q�6   .+�5M      �� -   5        $ 
AddEditBtn��5M      $	��150��5N      $��25��5O      $%��Добавить продукт��5P      5Q      5R      5S      �� 5V   
   $ Vertical=�6   $��1��5W      $��3��5X      $��Center=�5Y      $��Center=�5Z      .+�5[      �� -   5         ��Name$ ProductImage��5[      $	��200��5\      $��0 0 0 10q�5]      $	��200��5_      ��5^      �� *product.Image+5_      �� 5`      -   5        $ AddNewImageBtn��5`      $	��150��5a      $��25��5b      $��Добавить��5c      5d      5e      5f      5g      