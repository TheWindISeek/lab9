# 数据库相关
```mysql
/*
 Source Host           : localhost:3306
 Source Schema         : cs_financial

 Target Server Type    : MySQL
 Target Server Version : 8.0.16
 File Encoding         : 65001
*/
-- 创建数据库 cs_financial
create database cs_financial;

--设置字符集和外键
set names utf8mb4;
set foreign_key_checks = 0;

--创建用户表
drop table if exists cs_financial.'user';
create table cs_financial.'user' (
	
);

```