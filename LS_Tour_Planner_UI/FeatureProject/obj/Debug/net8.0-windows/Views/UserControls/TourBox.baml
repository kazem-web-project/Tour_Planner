   M S B A M L   `   `   `  ����I  EFeatureProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:FeatureProject.Views.UserControls!FeatureProject.Views.UserControls  5      /    )FeatureProject.Views.UserControls.TourBox   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:FeatureProject.Views.UserControls     5      $	��250��5      $	��300��6+   $��10q�5      .��5
      �   � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   � $��1��6    � ColumnDefinitions 5      �� 5      $��1* �6#   60   �� 5      $��1* �6#   60   .+�5      ]� $��0��6   
�������.+�5      �� $��10,0,0,0q�6   $	��Top=�6*   $
��Auto��6@   $��FROM:��6N   �� 5      $��10,0,0,0q�6   $	��Top=�6*   $
��Auto��6?   $	��TO:��6M   �� 5      $��10,0,0,0q�6   $	��Top=�6*   $
��Auto��6?   $��	DURATION:��6M   �� 5      $��10,0,0,0q�6   $	��Top=�6*   $
��Auto��6?   $��	DISTANCE:��6M   �� 5      $��10,0,0,0q�6   $	��Top=�6*   $
��Auto��6?   $��VEHICLE:��6M   �� 5      $��Bottom=�6   
�������
����� �$��25��6^   $��Select��6j   $��75��6{   5      ]� 5      $��1��6   
�������.+�5      �� -   5         ��Name$ TourData��5   5   $	��Top=�6   .@�5       �� ��6   �� *_from+�� 5!      ��6   �� *_to+�� 5"      ��6   �� *	_duration+�� 5#      ��6   �� *	_distance+�� 5$      ��6   �� *
_vehicle+5%      �� 5&      $��Bottom=�6   
�������
����� �$��25��6^   $��Delete Tour��6j   $��75��6�   5'      5(      �� 5*   
   -   5        $��	TourTitle��5*   >   $��0��6   $��24(�6   $��Light"�6+   $��Center=�5+      
�������$��Center=�5,      $��Center=�6#   $��Stretch=�6G   $
��Auto��5-   "   $��50��6/   ��6   �� *_name+6/   5.      50      