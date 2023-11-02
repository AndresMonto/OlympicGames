use heroku_e9b28472bbd7874;

CREATE TABLE `resulthalterofilia` (
  `Id` bigint(20) NOT NULL AUTO_INCREMENT,
  `Pais` varchar(500) NOT NULL,
  `Nombre` varchar(500) NOT NULL,
  `Arranque` int(11) NOT NULL,
  `Envion` int(11) NOT NULL,
  `TotalPeso` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=44 DEFAULT CHARSET=utf8;


create procedure SP_GetOrderedData()
begin
	select Id ,Pais, Nombre , max(Arranque) as Arranque, max(Envion) as Envion, max(Arranque) + max(Envion) as TotalPeso from ResultHalterofilia as RH 
	group by RH.Pais, RH.Nombre
	order by TotalPeso desc;
end;

