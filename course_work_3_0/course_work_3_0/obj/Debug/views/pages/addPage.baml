   M S B A M L   `   `   `  ����J  Fcourse_work_3_0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:course_work_3_0.views.pagescourse_work_3_0.views.pages  5      *    $course_work_3_0.views.pages.addPages   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:course_work_3_0.views.pages     5        N� Title$  addPages��5	      .��5
      � .+�5   
   �� $��Center=�6   $��Center=�5      .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� .+�5      �� -   5         ��Name$ textFIO��5       $��ФИО:��61   $��15(�6=   $��
0, 0, 0, 6q�6K   6a   �� 5      $ ��ДАТА РОЖДЕНИЯ:��6    $��15(�66   $��
0, 0, 0, 6q�6D   6Z   �� 5      $*��$СЕМЕЙНОЕ ПОЛОЖЕНИЕ:��6    $��15(�6;   $��
0, 0, 0, 6q�6I   6_   �� 5      $��ГРУППА:��6    $��15(�6/   $��
0, 0, 0, 6q�6=   6S   �� 5      $��	КУРС:��6    $��15(�6-   $��
0, 0, 0, 6q�6;   6Q   �� 5      $$��ГОД ПОСТУПЛЕНИЯ:��6    $��15(�68   $��
0, 0, 0, 6q�6F   6\   �� 5      $��СТИПЕНДИЯ:��6    $��15(�62   6B   5      �� 5      $��10, 0, 0, 0q�6   .+�5       �� -   5         ��Name$ INSERT_NAME��5       $	��150��63   $��
0, 0, 0, 6q�6?   6U   (  "System.Windows.Controls.DatePicker  5!      -   5          Name$ INSERT_DATE_BORN��5!   !   $��
0, 0, 0, 6q�6;   6Q   �� 5"      -   5        $ INSERT_MARITALSTATUS��5"      $��
0, 0, 0, 7q�6<   �� 5#      -   5         ��Name$ INSERT_GROUP��5#      $	��Top=�65   $��
0, 0, 0, 5q�6N   6d   �� 5$      -   5        $ INSERT_COURSE��5$      $	��150��65   $��
0, 0, 0, 7q�6A   6W     5%      -   5        $ INSERT_YEAR_ROLLMENT��5%   !   $��
0, 0, 0, 7q�6?   6U   �� 5&      -   5        $ INSERT_SCHOLARSHIP��5&      6<   5'      5(      �� 5+      $ 
Horizontal=�6   $��Center=�5,      $��Center=�5-      $��0, 15, 0, 0q�5.      .+�5/      �� -	   5        $��ReturnMainPage��50      $��ВЕРНУТЬСЯ��5/      $��0, 0, 10, 0q�51      $	��150��52      $��25��53      54      �� 55      -
   5         ��Name$ 	ADDButton��56      $��ДОБАВИТЬ��55      $	��150��57      $��25��58      59      5:      5;      5<      5>      