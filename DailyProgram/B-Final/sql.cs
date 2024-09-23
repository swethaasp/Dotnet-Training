SELECT Order_No, MAX(Prod_Price) AS Max_Prod_Price
FROM SALES_ORDER
WHERE Prod_Price < 100 OR Prod_Price > 500
GROUP BY Order_No;


SELECT Order_No, 
       MAX(CASE 
             WHEN Prod_Price < 100 OR Prod_Price > 500 THEN Prod_Price 
             ELSE NULL 
           END) AS Max_Prod_Price
FROM SALES_ORDER
GROUP BY Order_No;
