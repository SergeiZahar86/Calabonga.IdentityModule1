"Data Source=192.168.1.3,1433\\SQLEXPRESS;Initial Catalog=OrganizationDb_0;Trusted_Connection=True;"

docker run -d -p 1401:1433 -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=2712iwitn" -e "MSSQL_PID=Express" --name docker-sql mcr.microsoft.com/mssql/server:2019-CU12-ubuntu-20.04

docker run -d -p 663:80/tcp --name aspnetcore_sample 982615489037

http://localhost:10001/api/manual/index.html