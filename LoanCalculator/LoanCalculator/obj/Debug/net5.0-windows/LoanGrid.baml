   M S B A M L   `   `   `  ����I  ELoanCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:LoanCalculatorLoanCalculator  5          LoanCalculator.LoanGrid   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:LoanCalculator     5        N� Title$  LoanGrid��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ LoanDataGrid��5   A      AutoGenerateColumns$ False��6      
IsReadOnly$
 True��6/   $��1��6W   $��4��6d   $��10q�6x      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6%      Header$ День��62   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6@   �� *day+6Z     5      $
 auto 6%   $ Ставка��62   	 6B   �� *bet+6\     5      $
 auto 6%   $" % (накопительно)��62   	 6L   �� *accumulative+6o     5      $
 auto 6%   $ Сумма выплаты��62   	 6I   �� *paymentAmount+6m   5      �� 5   
   $��2��6   .+�5      �� -   5        
 ��Name$
 	TBSumLoan��5   -   $��Сумма займа: ��6   6-   �� 5       -   5        $
 TBSumDay��5    3   $&�� Срок займа (дней): ��6   63   5!      �� 5"   
   $��2��6   $��0��6)   $��2��66   .+�5#      �� -   5        $
 TBAllSumLoan��5#   5   $,��&Общая сумма выплаты: ��6   65   �� 5$      -   5        $
 TBProcentSum��5$   1   $%��Сумма процентов: ��6   61   �� 5%      -   5        $
 TBEffectiveBid��5%   4   $+��%Эффективная ставка: ��6   64   5&      5'      5(      