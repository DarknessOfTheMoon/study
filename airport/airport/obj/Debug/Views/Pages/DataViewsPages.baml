   M S B A M L   `   `   `  ����B  >airport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:airport.Views.Pagesairport.Views.Pages  5      (    "airport.Views.Pages.DataViewsPages   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:airport.Views.Pages     5      -   5        $
��1000��5   -     N� Title$  DataViewsPages��5	      .��5
      �  � RowDefinitions 5   
   �� 5      $	��100 �6   6+   �� 5      $	��280 �6   6+   �� 5      6   .+�5   
   � $��0��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $
��Left=�5      .+�5      �� -   5         ��Name$ 	searchTBX��5      $	��300��5      $��25��5      $��50, 0, 0, 0q�5      5   @   5      �� 5      $ 
Horizontal=�6   $��Right=�5      .+�5      �� -   5         ��Name$ editingDataViewBTN��5      $ ��РЕДАКТИРОВАТЬ��5       $��0, 0, 50, 0q�5!      61   �� 5"      -   5        $ deleteDataViewBTN��5"      $��УДАЛИТЬ��5$      $��0, 0, 50, 0q�5%      60   5&      5'      � 5*   
   $��1��6   .+�5+      &   System.Windows.Controls.DataGrid  -   5          Name$ ListDataView��5+         AutoGenerateColumns .     Columns 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 100 6Q   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 65   ��  �� Path$ id�6_     5/      $ ИМЯ��6)   $		 150 6W   
 66   �� $ surName�6e     50      $ ФАМИЛИЯ��6)   $		 150 6\   
 6:   �� $ lastName�6j     51      $ ОТЧЕСТВО��6)   $		 150 6_   
 6;   �� $ 
MaddleName�6m     52      $ ПОЛ��6)   $		 100 6_   
 66   �� $ Gender.IDgender�6m     53      $ ID-ПАСПОРТА��6)   $		 150 6c   
 6?   �� $ 
passportID�6q     54      $ ГРАЖДАНСТВО��6)   $		 100 6j   
 6?   �� $ citizenship.title�6x     55      $ РЕЙС��6)   $		 100 6Y   
 67   �� $ idFlight�6g   57      58      � 5;   
   $��2��6   .+�5<      �� $ 
Horizontal=�6   .+�5=      �� -   5        $ returnDataView��5>      $��
НАЗАД��5=      $��10, 0, 0, 0q�5@      60   �� 5A      -   5        $ flightDataView��5B      $(��"ПОДРОБНЕЕ О РЕЙСАХ��5A      $��100, 0, 0, 0q�5C      6N   5D      5E      5G      5H      