USE CallCenter;
SELECT * FROM Customers
--Trả ra số cuộc gọi thành công, số cuộc gọi thất bại(số cuộc gọi thất bại= số cuộc gọi bận+số cuộc gọi không nghe máy)
SELECT COUNT(cac.PhoneID) AS SoCuocGoiThanhCong
FROM CallDetail cac 
WHERE cac.StatusID='BU'
--Viết hàm đếm xem có bao nhiêu cuộc gọi thành công
CREATE FUNCTION FUN_COUNT_CALL_AN()
RETURNS INTEGER
AS
BEGIN
	RETURN(
		
		SELECT COUNT(cac.PhoneID)
		FROM CallDetail cac 
		WHERE cac.StatusID='AN'
	)
END;
--Viết hàm đếm xem có bao nhiêu cuộc gọi bận
CREATE FUNCTION FUN_COUNT_CALL_BU()
RETURNS INTEGER
AS
BEGIN
	RETURN(
		SELECT COUNT(cac.PhoneID)
		FROM CallDetail cac 
		WHERE cac.StatusID='BU'
	)
END;
--Viết hàm đếm xem có bao nhiêu cuộc gọi không trả lời
CREATE FUNCTION FUN_COUNT_CALL_NO()
RETURNS INTEGER
AS
BEGIN
	RETURN(
		SELECT COUNT(cac.PhoneID)
		FROM CallDetail cac 
		WHERE cac.StatusID='NO'
	)
END;
----
SELECT dbo.FUN_COUNT_CALL_AN() AS TOTALCALLSUCCESS
SELECT dbo.FUN_COUNT_CALL_BU() AS TOTALCALLBYSY
SELECT dbo.FUN_COUNT_CALL_NO() AS TOTALCALLNOANSWERED
--Viết store thống kê tình trạng các cuộc gọi
CREATE PROCEDURE SP_TOTAL_CALL_STT
AS
BEGIN
	SELECT dbo.FUN_COUNT_CALL_AN() AS TOTALCALLANSWERE
		   ,dbo.FUN_COUNT_CALL_BU() AS TOTALCALLBUSY
		   ,dbo.FUN_COUNT_CALL_NO() AS TOTALCALLNOAN
		   ,SUM(dbo.FUN_COUNT_CALL_BU()+dbo.FUN_COUNT_CALL_NO()) AS TOTALCALLFIELD
END;
EXECUTE dbo.SP_TOTAL_CALL_STT;
--trả về số điện thoại theo tên chủ số(khác hàng) truyền vào trạng thái của cuộc gọi(BUSY, ANSWERED, NO ANSWERED)
SELECT cac.PhoneID
	,cus.Name
FROM CallDetail cac
INNER JOIN PhoneNumbers p_num ON cac.PhoneID = p_num.PhoneNumber
INNER JOIN Customers cus ON p_num.CustomerID = cus.CustomerID
WHERE cac.StatusID = 'BU';
--Trả về số diện thoại theo từng khác hàng
SELECT cus.CustomerID
	,cus.Name
	,p_num.PhoneNumber
FROM Customers cus
INNER JOIN PhoneNumbers p_num ON cus.CustomerID = p_num.CustomerID
WHERE cus.CustomerID = 'KH1'
ORDER BY cus.CustomerID;
----Viết thủ tục trả về số điện thoại theo tên chủ số(khác hàng) truyền vào trạng thái của cuộc gọi(BUSY, ANSWERED, NO ANSWERED). Tham số truyền vào là trạng thái cuộc gọi
CREATE PROCEDURE SP_CALL_STATUS (@stt_call NCHAR(10))
AS
BEGIN
	SELECT cus.Name
		,cac.PhoneID
	FROM CallDetail cac
	INNER JOIN PhoneNumbers p_num ON cac.PhoneID = p_num.PhoneNumber
	INNER JOIN Customers cus ON p_num.CustomerID = cus.CustomerID
	WHERE @stt_call = cac.StatusID;
END;
EXECUTE dbo.SP_CALL_STATUS @stt_call='AN';
--Viết thủ tục trả về mã khách hàng, tên khác hàng, số điện thoại tương ứng khác hàng sắp xếp theo tên khách hàng. Tham số truyền vào là mã khách hàng
CREATE PROCEDURE SP_CUS_NUMBER(@cus_id NCHAR(10))
AS
BEGIN
	SELECT cus.CustomerID
	,cus.Name
	,p_num.PhoneNumber
	FROM Customers cus
	INNER JOIN PhoneNumbers p_num ON cus.CustomerID = p_num.CustomerID
	WHERE @cus_id= cus.CustomerID
	ORDER BY cus.CustomerID;
END;
EXECUTE dbo.SP_CUS_NUMBER @cus_id='KH1';
--Trả về tổng số cuộc gọi của mỗi nhân viên
SELECT DISTINCT cac.EmployeeID, COUNT(cac.PhoneID) AS TOTALCALL
FROM CallDetail cac
GROUP BY cac.EmployeeID;
--Trả về tổng số cuộc gọi của mỗi nhân viên mà có số cuộc gọi thành công
SELECT DISTINCT cac.EmployeeID, COUNT(cac.PhoneID) AS TOTALCALL
FROM CallDetail cac
WHERE cac.StatusID='AN'
GROUP BY cac.EmployeeID;
--Trả về tổng số cuộc gọi của mỗi nhân viên mà có số cuộc gọi bận
SELECT DISTINCT cac.EmployeeID, COUNT(cac.PhoneID) AS TOTALCALL
FROM CallDetail cac
WHERE cac.StatusID='BU'
GROUP BY cac.EmployeeID;
--Trả về tổng số cuộc gọi của mỗi nhân viên mà có số cuộc gọi không trả lời
SELECT DISTINCT cac.EmployeeID, COUNT(cac.PhoneID) AS TOTALCALL
FROM CallDetail cac
WHERE cac.StatusID='NO'
GROUP BY cac.EmployeeID;
---Hàm trả về tổng số cuộc gọi của mỗi nhân viên mà có số cuộc gọi thành công
CREATE FUNCTION FUN_COUNT_CALL_EMP_AN()
RETURNS INTEGER
AS
BEGIN
	RETURN(
		SELECT COUNT(cac.PhoneID)
		FROM CallDetail cac 
		WHERE cac.StatusID='AN'
		GROUP BY cac.EmployeeID
	)
END;
SELECT dbo.FUN_COUNT_CALL_EMP_AN() AS TOTALCALLSUCCESS
--Viết hàm đếm xem có bao nhiêu cuộc gọi bận
CREATE FUNCTION FUN_COUNT_CALL_EMP_BU()
RETURNS INTEGER
AS
BEGIN
	RETURN(
		SELECT COUNT(cac.PhoneID)
		FROM CallDetail cac 
		WHERE cac.StatusID='BU'
		GROUP BY cac.EmployeeID
	)
END;
--Viết hàm đếm xem có bao nhiêu cuộc gọi không trả lời
CREATE FUNCTION FUN_COUNT_CALL_EMP_NO()
RETURNS INTEGER
AS
BEGIN
	RETURN(
		SELECT COUNT(cac.PhoneID)
		FROM CallDetail cac 
		WHERE cac.StatusID='NO'
		GROUP BY cac.EmployeeID
	)
END;
-----
SELECT     dbo.FUN_COUNT_CALL_EMP_AN() AS TOTALCALLEMPANSWERE
		   ,dbo.FUN_COUNT_CALL_EMP_BU() AS TOTALCALLEMPBUSY
		   ,dbo.FUN_COUNT_CALL_EMP_NO() AS TOTALCALLEMPNOAN
		   ,SUM(dbo.FUN_COUNT_CALL_BU()+dbo.FUN_COUNT_CALL_NO()) AS TOTALCALLFIELD
		   ,CAST(dbo.FUN_COUNT_CALL_EMP_AN() AS FLOAT)/CAST(dbo.FUN_COUNT_CALL_EMP_BU()+dbo.FUN_COUNT_CALL_EMP_NO() AS FLOAT)  AS TILECALLSUCCESS
		  
SELECT cac.EmployeeID,(SELECT COUNT(cac.PhoneID) FROM CallDetail cac WHERE cac.StatusID='AN') AS 'NGHE MÁY'
					 ,(SELECT COUNT(cac.PhoneID) FROM CallDetail cac WHERE cac.StatusID='BU') AS 'MÁY BẬN'
					 ,(SELECT COUNT(cac.PhoneID) FROM CallDetail cac WHERE cac.StatusID='NO') AS 'KHÔNG NGHE MÁY'
FROM CallDetail cac
GROUP BY cac.EmployeeID;