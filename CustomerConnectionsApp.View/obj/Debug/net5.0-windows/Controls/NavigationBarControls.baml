   M S B A M L   `   `   `  ����U  QCustomerConnectionsApp.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:CustomerConnectionsApp.WPF.Controls#CustomerConnectionsApp.WPF.Controls  5      i9clr-namespace:CustomerConnectionsApp.WPF.State.Navigators+CustomerConnectionsApp.WPF.State.Navigators  5      7    1CustomerConnectionsApp.WPF.Controls.NavigationBar   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:CustomerConnectionsApp.WPF.Controls     5      Inav9clr-namespace:CustomerConnectionsApp.WPF.State.Navigators     5      .��5      �   � RowDefinitions  5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6    �� Padding$ 10q�6!   $��28(�6.   $��Customer Connections��6<      RedBrush#��[  6X   � 5   
   $��1��6    �� EdgeMode$ Aliased=�6     	GrayBrush#��[ 6=    � 	Resources 5       �� 
TargetType  	NavButton �� BasedOn��%0   '	�       7  �� 5      " 	�6   8   61   5       � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $��* �6#   .+�5       	� $��0��6   $
��Home��6*   :   4CustomerConnectionsApp.WPF.State.Navigators.ViewType   Home#��Z 6k   ��69   �� *UpdateCurrentViewModelCommand+6k   	� 5!      $��1��6   $��Customer��6*      Customer#��Z 6o   ��6=   �� *UpdateCurrentViewModelCommand+6o   	� 5"      $��2��6   $	��Job��6*   
	   Job#��Z	 6j   ��68   �� *UpdateCurrentViewModelCommand+6j   	� 5#      $��3��6   $��Hardware��6*   
   Hardware#��Z
 6o   ��6=   �� *UpdateCurrentViewModelCommand+6o   5%      5&      5'      