   M S B A M L   `   `   `  ����H  DChainOfStores, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ChainOfStores.Views.PagesChainOfStores.Views.Pages  5      ,    &ChainOfStores.Views.Pages.DataViewPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:ChainOfStores.Views.Pages     5        N� Title$  DataViewPage��5	      .��5
      �  � RowDefinitions 5   
   �� 5      $��90 �6   6*   �� 5      $��40 �6   6*   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $	��100 �6   6+   .+�5   
   � $��0��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�5      $��Center=�5      .+�5      �� $ Vertical=�6   .+�5      �� $��15, 0, 0, 0q�6    $��15(�5       $��Lobster-Regular)�5       
ПОИСК6D   �� 5      -   5         ��Name$ 	SearchTBX��5      $	��400��5      $��40��5      $��15, 0, 15, 0q�5       65   5!      �� 5#      $ 
Horizontal=�6   $��0, 18, 0, 0q�5$      .+�5%      �� -   5         ��Name$ 	DeleteBTN��5%      $��УДАЛИТЬ��5&         
MainButton#��[  5'      $��
0, 0, 5, 0q�5(      6K   �� 5)      -   5        $ EditBTN��5)      $ ��РЕДАКТИРОВАТЬ��5*      #��[  5+      $��
5, 0, 0, 0q�5,      6J   5-      5/      50      � 52   
   $��1��6   .+�53      �� $#��СПИСОК ПОСТАВОК��6   $��Center=�54        AddSupplyTXB#��[ 55      56      � 58   
   $��2��6   .+�59      &   System.Windows.Controls.DataGrid  -   5          Name$ DataViewProvid��59         AutoGenerateColumns .     Columns 5;      0  *System.Windows.Controls.DataGridTextColumn  5<      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 200 6L   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 65   �� *ID+6Z     5=      $' !НАЗВАНИЕ МАГАЗИНА��6)   $		 200 6h   
 6D   �� *STORE.NameStore+6v     5>      $ 
АДРЕС��6)   $		 200 6Z   
 68   �� *STORE.Address+6h     5?      $! ИМЯ ПОСТАВЩИКА��6)   $		 200 6f   
 6A   �� *PROVIDER.SurName+6t     5@      $) #ФАМИЛИЯ ПОСТАВЩИКА��6)   $		 200 6k   
 6E   �� *PROVIDER.LastName+6y   5B      5C      � 5D   
   $��3��6   .+�5E        -   5        $ DataViewOwnerSupply��5E       .   5G        5H      $ ИМЯ КЛИЕНТА��6)   $		 250 6`   
 6>   �� *OWNER.SurName+6n     5I      $# ФАМИЛИЯ КЛИЕНТА��6)   $		 250 6e   
 6B   �� *OWNER.LastName+6s     5J      $' !НОМЕР РЕГИСТРАЦИИ��6)   $		 250 6q   
 6D   �� *OWNER.NumberRegistration+6     5K      $% ДАТА РЕГИСТРАЦИИ��6)   $		 250 6o   
 6C   �� *OWNER.DateRregistration+6}   5M      5N      � 5P   
   $��4��6   .+�5Q      �� $ 
Horizontal=�6   $	��100��5R      $��10, 20, 0, 0q�5S      .+�5T      �� -   5        $$ returnDataViewPageinChoicePage��5T      $��ВЕРНУТЬСЯ��5V      #��[  5W      6?   �� 5X      -   5        $ NextPageOne��5X      $)��#СЛЕДУЮЩАЯ СТРАНИЦА��5Z      #��[  5[      $��100, 0, 0, 33q�5\      62   5]      5_      5a      5b      