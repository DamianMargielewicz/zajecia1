   M S B A M L   `   `   `  ����  App.DesktopClient)    #App.DesktopClient.Views.DevicesView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      P LPrism.Wpf, Version=6.3.0.0, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59#mvvmhttp://prismlibrary.com/  5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  . .��5
      � $��10q�6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��4��6   $��0��6'   $��1��67   $��3��6D   ��6U   �� *ResultOfSearchInDevices+ �� View 5      �� 5      .P�5      �� $��Nazwa��6%    �� Width$
 auto��64    �� DisplayMemberBinding 6A   �� *Name+�� 5      $��Miejsce��6%   $
 auto��66    6C   �� *
Place.Name+�� 5      $	��Typ��6%   $
 auto��62    6?   �� *DeviceType.Name+�� 5      $
��Opis��6%   $
 auto��63    6@   �� *Description+5      5       �� 5!   
   $��0��6   $��3��6   $��1��63    �� TextWrapping$
 Wrap=�6C   $��Center=�6�   ��6W   �� *SearchExpression+ �� UpdateSourceTrigger$ PropertyChanged=�6�   5"      5#      