   M S B A M L   `   `   `  ����H  DChainOfStores, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:ChainOfStores.Views.Pages.DataViews#ChainOfStores.Views.Pages.DataViews  5      6    0ChainOfStores.Views.Pages.DataViews.DataViewShop   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:ChainOfStores.Views.Pages.DataViews     5      -   5          N� Title$  DataViewShop��5	      .��5
      �  � RowDefinitions 5   
   �� 5      $��90 �6   6*   �� 5      $��40 �6   6*   �� 5      $��* �6   6)   �� 5      $	��100 �6   6+   .+�5   
   � $��0��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�5      $��Center=�5      .+�5      �� $ Vertical=�6   .+�5      �� $��15, 0, 0, 0q�6    $��15(�5       $��Lobster-Regular)�5       
ПОИСК6D   �� 5      -   5         ��Name$ 	SearchTBX��5      $	��400��5      $��40��5      $��15, 0, 15, 0q�5      65   5       �� 5"      $ 
Horizontal=�6   $��0, 18, 0, 0q�5#      .+�5$      �� -   5         ��Name$ 	DeleteBTN��5$      $��УДАЛИТЬ��5%         
MainButton#��[  5&      $��
0, 0, 5, 0q�5'      6K   �� 5(      -   5        $ EditBTN��5(      $ ��РЕДАКТИРОВАТЬ��5)      #��[  5*      $��
5, 0, 0, 0q�5+      6J   5,      5.      5/      � 51   
   $��1��6   .+�52      �� $%��СПИСОК МАГАЗИНОВ��6   $��Center=�53        AddSupplyTXB#��[ 54      55      � 57   
   $��2��6   .+�58      &   System.Windows.Controls.DataGrid  -   5          Name$ DataViewAddShop��58         AutoGenerateColumns .     Columns 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 142 6Q   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 65   �� *	IDstore+6_     5<      $' !НАЗВАНИЕ МАГАЗИНА��6)   $		 142 6b   
 6D   �� *	NameStore+6p     5=      $ 
АДРЕС��6)   $		 142 6T   
 68   �� *	Address+6b     5>      $! НОМЕР ТЕЛЕФОНА��6)   $		 142 6a   
 6A   �� *NumberStore+6o     5?      $' !ФАМИЛИЯ ВЛАДЕЛЬЦА��6)   $		 142 6f   
 6D   �� *OWNER.SurName+6t     5@      $ ИМЯ ВЛАДЕЛЬЦА��6)   $		 142 6c   
 6@   �� *OWNER.LastName+6q     5A      $ ПРОФИЛЬ��6)   $		 142 6\   
 6:   �� *PROFILE.TITLE+6j   5C      5D      � 5F   
   $��3��6   .+�5G      �� $ 
Horizontal=�6   $	��100��5H      $��10, 20, 0, 0q�5I      .+�5J      �� -   5        $$ returnDataViewPageinChoicePage��5J      $��ВЕРНУТЬСЯ��5L      #��[  5M      6?   �� 5N      -   5        $ NextPageFour��5N      $)��#СЛЕДУЮЩАЯ СТРАНИЦА��5P      #��[  5Q      $��100, 0, 0, 33q�5R      62   5S      5U      5W      5X      