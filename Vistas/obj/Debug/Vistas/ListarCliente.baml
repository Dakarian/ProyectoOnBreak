   M S B A M L   `   `   `  ����A  =Vistas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:VistasVistas  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5
      V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5          Vistas.ListarCliente   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Vistas     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	      N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5
      JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5        � Title$  ListarCliente��5   	   $��325.454��6   $	��300��60    � WindowStartupLocation$ Manual=�6<   
 � Top$	 214��6[    � Left$	 136��6e    � 
ResizeMode$ NoResize=�6p   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgridCliente��5      $
��Left=�6)   $	��159��6D   $	��Top=�6Q   $	��294��6i   �� 5   
   -   5         ��Name$ btn_Actualizar��5      $�� ��6)   $
��Left=�64   $��207,168,0,0q�6O   $	��Top=�6d   $��25��6|   $��25��6�   ��5      �� 5       �� ImageSource$3 -/Vistas;component/Iconos/Data-Synchronize.png��6    j� Stretch$ Uniform=�6Y   5      �� 5   
   -   5        	 ��Name$	 txtRut��5      *  $MahApps.Metro.Controls.TextBoxHelper
   	Watermark$
 Ingrese Rut��6"   %   IsSpellCheckContextMenuEnabled .    ClearTextButton . $
��Left=�6�   $��23��6�   $��
60,167,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6  $	��120��6$   �� 	MaxLength$ 12��60  6?  �� 5   
   $	��Rut��6   $
��Left=�6   $��
10,167,0,0q�69   $	��Top=�6M   �� 5   
   -   5        $ 	btnVolver��5      $�� ��6$   $��262,271,0,0q�6/   $
��Left=�6\   $��32��6w   ��5      �� 5      $5 //Vistas;component/Iconos/Arrowhead-Right-01.png��6   $ Uniform=�6[   5      �� 5   
   -   5        $ btnEliminar��5      $�� ��6&   $
��Left=�61   $��207,228,0,0q�6L   $	��Top=�6a   $��25��6y   $��25��6�   ��5      �� 5      $1 +/Vistas;component/Iconos/Garbage-Closed.png��6   $ Uniform=�6W   5       �� 5!   
   $��Nombre��6   $
��Left=�6!   $��	0,198,0,0q�6<   $	��Top=�6O   �� 5"   
   -   5        $	 	txtNombre��5"      $
 Ingrese Nombre��6%    .  . $
��Left=�6�   $��23��6�   $��
60,198,0,0q�6�   $
 Wrap=�6�   $	��Top=�6  $	��129��6)  $ 25��65  6D  �� 5#   
   $��Empresa��6   $
��Left=�6"   $��	0,229,0,0q�6=   $	��Top=�6P   �� 5$   
   -   5        $	 
txtEmpresa��5$      $
 Ingrese Empresa��6&    .  . $
��Left=�6�   $��23��6�   $��
60,229,0,0q�6�   $
 Wrap=�6�   $	��Top=�6  $	��129��6+  $ 15��67  6F  �� 5%   
   -   5        $ btnTraspasar��5%      $�� ��6'   $
��Left=�62   $��207,199,0,0q�6M   $	��Top=�6b   $��25��6z   $��25��6�   ��5&      �� 5'      $( "/Vistas;component/Iconos/Check.png��6   $ Uniform=�6N   5)      �� 5*   
   $��	Traspasar��6   $
��Left=�6$   $��237,198,0,0q�6?   $	��Top=�6T   $��57��6l   
������ $��10(�6�   �� 5+   
   $��Eliminar��6   $
��Left=�6#   $��239,228,0,0q�6>   $	��Top=�6S   $��10(�6k   �� 5,   
   $��
Actualizar��6   $
��Left=�6%   $��237,169,0,0q�6@   $	��Top=�6U   $��10(�6m   5.      5/      