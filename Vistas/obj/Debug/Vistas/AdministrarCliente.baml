   M S B A M L   `   `   `  ����A  =Vistas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistasVistas  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5
   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	       Vistas.AdministrarCliente   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Vistas     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5
   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	     � Title$  AdministrarCliente��5   	   $��556.362��6$   $��409.381��65    � 
ResizeMode$ NoResize=�6E    � WindowStartupLocation$ CenterScreen=�6[   .��5      � $��0,0,2,7q�6    � ColumnDefinitions 5   
   �� 5      .+�5   
   �� -   5         ��Name$ groupBox��5      $��Datos Personales��6%   $
��Left=�6?   $��	10,18,0,0q�6Z   $	��Top=�6m   $	��502��6�   $	��385��6�   .��5      � $
��Left=�6   $	��461��6.   $��
4,10,0,-60q�6;   $	��Top=�6O   $	��371��6g   .+�5      �� -   5         ��Name$ txt_rut��5      *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Ingrese Rut��6+   %   IsSpellCheckContextMenuEnabled .    ClearTextButton . $
��Left=�6�   $��23��6�   $��
110,27,0,0q�6�   	 �� TextWrapping$
	 Wrap=�6   $	��Top=�6  $	��120��6,  
 �� 	MaxLength$
 12��6Z  �� 5      -   5         ��Name$ label2��5      $	��Rut��6(   $
��Left=�66   $��	37,27,0,0q�6Q   $	��Top=�6d   �� 5      -   5        $ label3��5      $��Nombre��6(   $
��Left=�69   $��	11,63,0,0q�6T   $	��Top=�6g   �� 5      -   5        $ label4��5      $��Email��6(   $
��Left=�68   $��
28,137,0,0q�6S   $	��Top=�6g   �� 5      -   5        $ label5��5      $��Telefono��6(   $
��Left=�6;   $��
11,214,0,0q�6V   $	��Top=�6j   �� 5      -   5        $ label��5      $��	Actividad��6'   $
��Left=�6;   $��
40,273,0,0q�6V   $	��Top=�6j   �� 5      -   5        $ txt_nom��5      $ Ingrese Nombre��6+    . $
��Left=�6�   $��23��6�   $��
110,63,0,0q�6�   $
	 Wrap=�6�   $	��Top=�6�   $	��172��6�   $
 30��6�   �� 5      -	   5        $ 	txt_razon��5      $ Ingrese Razon Social��6-    . $
��Left=�6�   $��23��6�   $��110,102,0,0q�6�   $
	 Wrap=�6�   $	��Top=�6�   $	��172��6�   $
 20��6  �� 5      -
   5        $ 	txt_email��5      $ ejemplo@alumnos.duoc.cl��6-    . $
��Left=�6�   $��23��6�   $��110,137,0,0q�6�   $
	 Wrap=�6�   $	��Top=�6�   $	��172��6�   $
 30��6
  �� 5      -   5        $ txt_direccion��5      $ Ingrese Direccion��61    . $
��Left=�6�   $��23��6�   $��110,177,0,0q�6�   $
	 Wrap=�6�   $	��Top=�6�   $	��172��6�   $
 30��6  �� 5      -   5        $ txt_telefono��5      $ 
9 12345678��60    . $
��Left=�6�   $��23��6�   $��110,217,0,0q�6�   $
	 Wrap=�6�   $	��Top=�6�   $	��120��6�   $
 9��6   6  �� 5      -   5         ��Name$ cbo_actividad��5      $
��Left=�62   $��
13,299,0,0q�6M   $	��Top=�6a   $	��120��6y   �� 5       -   5        $ cbo_empresa��5       $
��Left=�60   $��178,299,0,0q�6K   $	��Top=�6`   $	��120��6x   �� 5!      -   5        $ label1��5!      $��Empresa��6(   $
��Left=�6:   $��212,273,0,0q�6U   $	��Top=�6j   �� 5"      -   5         ��Name$ btn_grabarcli��5"      $��Guardar��60   $
��Left=�6B   $��
28,368,0,0q�6]   $	��Top=�6q   $��75��6�   $��30��6�   6�   �� 5#      -   5        $ btn_limpiar��5#      $��Limpiar��6.   $
��Left=�6@   $��136,369,0,0q�6[   $	��Top=�6p   $��76��6�   6�   �� 5$      -   5        $ label3_Copy��5$      $��Razón Social��6-   $
��Left=�6D   $��
11,102,0,0q�6_   $	��Top=�6s   �� 5%      -   5        $ label4_Copy��5%      $��
Dirección��6-   $
��Left=�6A   $��
27,168,0,0q�6\   $	��Top=�6p   �� 5&      -   5        $ 
btn_buscar��5&      $�� ��6-   $
��Left=�68   $��
240,24,0,0q�6S   $	��Top=�6g   $��47��6   $��29��6�   ��5'      �� 5(       �� ImageSource$' !/Vistas;component/Iconos/Help.png��6%    j� Stretch$ Uniform=�6U   5*      �� 5+      -   5        $ 
btn_volver��5+      $
��Left=�6-   $��30��6H   $��293,421,0,0q�6T   $	��Top=�6i   $��68��6�   $��0��6�   $��Volver��6�   �� 5,      -   5        $ btn_Modificar��5,      $��	Modificar��60   $
��Left=�6D   $��240,369,0,0q�6_   $	��Top=�6t   $��75��6�   $��29��6�   6�   5-      5.      50      51      