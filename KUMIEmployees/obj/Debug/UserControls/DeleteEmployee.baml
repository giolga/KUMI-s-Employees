   M S B A M L   `   `   `  ����H  DKUMIEmployees, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:KUMIEmployees.UserControlsKUMIEmployees.UserControls  5      /    )KUMIEmployees.UserControls.DeleteEmployee   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:KUMIEmployees.UserControls     5      -   5        $��DeleteEmployeeUC��5      $	��600��5	      $
��1000��5
      .��5      �   � ColumnDefinitions  5   
   �� 5      $
��0.3* �6   �� 5      $��* �6   .+�5   
   � $��0��6   ���#D9B8E2.+�5      ��  �� Orientation$ Vertical=�6   $��Center=�60   $	��Top=�6M   $��0, 50, 0, 0q�6e   .+�5      �� -   5        $��ProfilePicture��5   D   $��/Images/add-person.png��6   $	��150��68   6D   �� 5      $ 
Horizontal=�6   $��0,20,0,0q�66   .+�5      �� -   5        $��
EmployeeId��5   >   $��
5, 0, 5, 0q�6   $��35��62   ���#FFE8D6$��94��6f   $
��Left=�6q    �� TextWrapping$
 Wrap=�6�   $��Center=�6�   $��16(�6�   .��6�   ��5      �� 5       �� Color$ Black��6.   .��5   /   ��5      �� 5       �� 
TargetType" ��6.   .R�5   "   ��  �� CornerRadius$ 5��6)   #��z��6:   ._�5   &   ��  ��Name$ PART_ContentHost��63   5   #   5      .��5    ,   5!      �� 5"      -   5        $��	SearchBtn��5"   l   $��35��6   $��63��6)   $��Right=�64   $��Bottom=�6P   $��18(�6�   $��Search��5%   *   ��5&      �� 5'       �� 
TargetType" ��6%   .�5(   "   ��  �� Property � ��	 �� Value
	 �����6?   �� 5)   "    � ��$	 SemiBold"�6?   5*      ��5,      �� 5-      " ��6.   .R�5.   "   �� $ 2��6)   $��1q�6:   ���#521d0b���#9F4DB5._�5/   &   �� $��Center=�67   $��Center=�6T   50   #   51      53      54      55      56      � 58   
   -   5        $��InfoGrid��58   4   $��1��6   ���#D8E9F75:      5;      5<      