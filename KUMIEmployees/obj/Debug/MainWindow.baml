   M S B A M L   `   `   `  ����H  DKUMIEmployees, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:KUMIEmployeesKUMIEmployees  5   	   G(clr-namespace:KUMIEmployees.UserControlsKUMIEmployees.UserControls  5   	       KUMIEmployees.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:KUMIEmployees     5   	   7uc(clr-namespace:KUMIEmployees.UserControls     5   	     � Title$  
MainWindow��5	   	   $	��900��6   $
��1200��6)    � WindowStartupLocation$ CenterScreen=�66   .��5
      � .+�5   
   �� .@�5      �� $��Show All��6   .��5      � $
��1000��6   $��Center=�6$   .+�5      �� $��Show All��6   &   System.Windows.Controls.DataGrid  5      -   5          Name$ 	ShowAllDG��5         AutoGenerateColumns .     CanUserAddRows .     SelectionUnit$
 Cell=�6f   "   VerticalScrollBarVisibility$
 Auto=�6{   $	��400��6�   $	��870��6�      
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Employee Id��61   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 75 6]   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   �� *Id+6]     5      $
	 Name��61   $
 75 6X    6?   �� *Name+6X     5      $	 Surename��61   $
 90 6`    6C   �� *
Surename+6`     5      $	 Personal Id��61   $
 90 6e    6F   �� *
PersonalId+6e     5      $	 Gmail��61   $	
 160 6Z    6@   �� *Email+6Z     5      $	 Job Position��61   $
 80 6g    6G   �� *JobPosition+6g     5      $	 Telephone Number��61    6K   �� *Tel+  5      $	 Salary��61   $
 50 6\    6A   �� *Salary+6\     5      $	 Bonus��61   $
 * 6@    6J   �� *Bonus+5      5      5      �� 5!      $��Add Employee��6   .��5#      ,   &KUMIEmployees.UserControls.AddEmployee  -   5          Name$ addEmployeeUC��5#   !   5%      �� 5'      $��Get Employee��6   .��5)      ,   &KUMIEmployees.UserControls.GetEmployee  -   5          Name$ 
getEmploye��5)   !   67   5*      �� 5,      $��Delete Employee��6   .��5.      /   )KUMIEmployees.UserControls.DeleteEmployee  5/      50      51      52      