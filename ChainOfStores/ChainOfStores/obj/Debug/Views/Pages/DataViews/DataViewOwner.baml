   M S B A M L   `   `   `  ����H  DChainOfStores, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:ChainOfStores.Views.Pages.DataViews#ChainOfStores.Views.Pages.DataViews  5      7    1ChainOfStores.Views.Pages.DataViews.DataViewOwner   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:ChainOfStores.Views.Pages.DataViews     5      -   5          N� Title$  DataViewOwner��5	      .��5
      �  � RowDefinitions 5   
   �� 5      $��90 �6   6*   �� 5      $��40 �6   6*   �� 5      $��* �6   6)   �� 5      $	��100 �6   6+   .+�5   
   � $��0��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�5      $��Center=�5      .+�5      �� $ Vertical=�6   .+�5      �� $��15, 0, 0, 0q�6    $��15(�5       $��Lobster-Regular)�5       
ПОИСК6D   �� 5      -   5         ��Name$ 	SearchTBX��5      $	��400��5      $��40��5      $��15, 0, 15, 0q�5      65   5       �� 5"      $ 
Horizontal=�6   $��0, 18, 0, 0q�5#      .+�5$      �� -   5         ��Name$ 	DeleteBTN��5$      $��УДАЛИТЬ��5%         
MainButton#��[  5&      $��
0, 0, 5, 0q�5'      6K   �� 5(      -   5        $ EditBTN��5(      $ ��РЕДАКТИРОВАТЬ��5)      #��[  5*      $��
5, 0, 0, 0q�5+      6J   5,      5.      5/      � 51   
   $��1��6   .+�52      �� $#��СПИСОК КЛИЕНТОВ��6   $��Center=�53        AddSupplyTXB#��[ 54      55      � 57   
   $��2��6   .+�58      &   System.Windows.Controls.DataGrid  -   5          Name$ DataViewAddOwner��58         AutoGenerateColumns .     Columns 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 100 6Q   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 65   �� *	IDowner+6_     5<      $ ИМЯ��6)   $		 125 6R   
 66   �� *	SurName+6`     5=      $ ФАМИЛИЯ��6)   $		 125 6W   
 6:   �� *
LastName+6e     5>      $ ОТЧЕСТВО��6)   $		 125 6Z   
 6;   �� *
MiddleName+6h     5?      $! НОМЕР ТЕЛЕФОНА��6)   $		 125 6a   
 6A   �� *NumberOwner+6o     5@      $ СУММА ВКЛАДА��6)   $		 125 6b   
 6?   �� *DepositAamount+6p     5A      $' !НОМЕР РЕГИСТРАЦИИ��6)   $		 140 6k   
 6D   �� *NumberRegistration+6y     5B      $% ДАТА РЕГИСТРАЦИИ��6)   $		 130 6i   
 6C   �� *DateRregistration+6w   5D      5E      � 5G   
   $��3��6   .+�5H      �� $ 
Horizontal=�6   $	��100��5I      $��10, 20, 0, 0q�5J      .+�5K      �� -   5        $$ returnDataViewPageinChoicePage��5K      $��ВЕРНУТЬСЯ��5M      #��[  5N      6?   �� 5O      -   5        $ NextPageFhree��5O      $)��#СЛЕДУЮЩАЯ СТРАНИЦА��5Q      #��[  5R      $��100, 0, 0, 33q�5S      62   5T      5V      5X      5Y      