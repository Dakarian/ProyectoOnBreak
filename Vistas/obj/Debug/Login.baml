   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours  5      V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5	      A =Vistas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistasVistas 5   	      Vistas.Login   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5      JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5	       localclr-namespace:Vistas  5   	     � Title$  Login��5   	   $	��327��6   $	��324��6$    � 
ResizeMode$ NoResize=�60    � WindowStartupLocation$ CenterScreen=�6F   .��5      � .+�5   
   � $
��Left=�6   $	��250��6*   $��	36,30,0,0q�67   $	��Top=�6J   $	��272��6b   .+�5      �� -   5         ��Name$ image��5      $
��Left=�6#   $��33��6>   $	��Top=�6J   $	��150��6b   $(��"Iconos/Logo Duoc UC Escuela IT.jpg��6n   �� 5      -   5        $ image1��5      $
��Left=�6$   $��76��6?   $��	93,38,0,0q�6K   $	��Top=�6^   $��79��6v   $&�� Iconos/logo_white_background.jpg��6�   $
��Fill=�6�   �� 5      -   5         ��Name$ txt_user��5      $
��Left=�6(   $��23��6C   $��
75,132,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��120��6�   *   $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Ingrese usuario��6�    �� 	MaxLength$ 10��6�   G� 5      -   5         G�Name$ pw_pass��5      .   (MahApps.Metro.Controls.PasswordBoxHelper	   CapsLockWarningToolTip$	 MAYUSC activado��6+   $ Ingrese contraseña��6o   
 G� 	MaxLength$
 10��6�   $��75,164,77,60q�6�   �� 5      -   5         ��Name$ label��5      $��Usuario:��6#   $
��Left=�66   $��
12,132,0,0q�6Q   $	��Top=�6e   �� 5      -   5        $ label1��5      $��Contraseña:��6$   $
��Left=�6:   $��
-7,163,0,0q�6U   $	��Top=�6i   �� 5      -   5         ��Name$ btn_inisesion��5      $��Iniciar sesión��6,   $
��Left=�6E   $��
75,201,0,0q�6`   $	��Top=�6t   $	��120��6�   6�   5      5      5      