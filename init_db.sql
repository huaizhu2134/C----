-- 古茗奶茶收银系统 - 数据库初始化脚本
-- 连接：mysql -uroot -p
-- 执行本脚本前请确保MySQL服务已启动

-- 创建数据库
DROP DATABASE IF EXISTS dfhz;
CREATE DATABASE dfhz DEFAULT CHARSET utf8mb4 COLLATE utf8mb4_general_ci;
USE dfhz;

-- 设置客户端字符集
SET NAMES utf8mb4;

-- ==================== 表结构 ====================

-- 店铺表
CREATE TABLE dianpu(
    dianpu_id INT PRIMARY KEY AUTO_INCREMENT,
    dianpu_name VARCHAR(100) NOT NULL,
    dizhi VARCHAR(200)
);

-- 用户表（员工）
CREATE TABLE yonghu(
    yonghu_id INT PRIMARY KEY AUTO_INCREMENT,
    yonghu_ming VARCHAR(50) UNIQUE NOT NULL,
    mima_hash VARCHAR(64) NOT NULL,
    juese ENUM('dianzhang','shouyinyuan') DEFAULT 'shouyinyuan',
    zhenshi_name VARCHAR(50),
    dianpu_id INT
);

-- 产品表（奶茶饮品）
CREATE TABLE chanye(
    chanye_id INT PRIMARY KEY AUTO_INCREMENT,
    chanye_name VARCHAR(100) NOT NULL,
    danjia DECIMAL(10,2) NOT NULL,
    fenlei ENUM('naicha','guocha','qita') DEFAULT 'naicha',
    zhuangtai BIT DEFAULT 1
);

-- 库存表（原料）
CREATE TABLE kucun(
    kucun_id INT PRIMARY KEY AUTO_INCREMENT,
    yuanliao_name VARCHAR(100) NOT NULL,
    danwei VARCHAR(10) NOT NULL,
    shuliang DECIMAL(10,3) DEFAULT 0,
    anquan_xian DECIMAL(10,3) DEFAULT 0
);

-- 配方表
CREATE TABLE peifang(
    peifang_id INT PRIMARY KEY AUTO_INCREMENT,
    chanye_id INT NOT NULL,
    yuanliao_name VARCHAR(100) NOT NULL,
    yongliang DECIMAL(10,3) NOT NULL,
    UNIQUE(chanye_id, yuanliao_name)
);

-- 会员表
CREATE TABLE huiyuan(
    huiyuan_id VARCHAR(20) PRIMARY KEY,
    shouji VARCHAR(20) UNIQUE NOT NULL,
    xingming VARCHAR(50),
    yue DECIMAL(10,2) DEFAULT 0,
    jifen INT DEFAULT 100,
    zhekou DECIMAL(3,2) DEFAULT 0.95
);

-- 订单表
CREATE TABLE dingdan(
    dingdan_id VARCHAR(20) PRIMARY KEY,
    dianpu_id INT,
    huiyuan_id VARCHAR(20),
    xiadanshijian DATETIME DEFAULT CURRENT_TIMESTAMP,
    yingshou DECIMAL(10,2),
    shishou DECIMAL(10,2),
    zhifufangshi ENUM('xianjin','weixin','yue') DEFAULT 'xianjin',
    zhuangtai BIT DEFAULT 1
);

-- 订单明细表
CREATE TABLE dingdan_mingxi(
    mingxi_id INT PRIMARY KEY AUTO_INCREMENT,
    dingdan_id VARCHAR(20),
    chanye_id INT,
    shuliang INT,
    danjia DECIMAL(10,2)
);

-- 库存日志表
CREATE TABLE kucun_rizhi(
    rizhi_id INT PRIMARY KEY AUTO_INCREMENT,
    yuanliao_name VARCHAR(100),
    bianhua DECIMAL(10,3),
    zhuangtai ENUM('ruku','xiaohao') DEFAULT 'ruku',
    beizhu VARCHAR(200),
    shijian DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- 营业统计表（每日汇总）
CREATE TABLE yingye_tongji(
    tongji_id INT PRIMARY KEY AUTO_INCREMENT,
    riqi DATE UNIQUE,
    dingdan_shu INT DEFAULT 0,
    xiaoliang INT DEFAULT 0,
    yingye_e DECIMAL(12,2) DEFAULT 0
);

-- ==================== 初始数据 ====================

-- 店铺
INSERT INTO dianpu(dianpu_name, dizhi) VALUES 
('古茗-软件学院店', '大学城软件学院一楼');

-- 用户（密码均为123456，明文存储）
INSERT INTO yonghu(yonghu_ming, mima_hash, juese, zhenshi_name, dianpu_id) VALUES
('admin', '123456', 'dianzhang', '张店长', 1),
('zhangsan', '123456', 'shouyinyuan', '张三', 1),
('lisi', '123456', 'shouyinyuan', '李四', 1);

-- 产品（古茗经典饮品）
INSERT INTO chanye(chanye_name, danjia, fenlei) VALUES
-- 奶茶系列
('珍珠奶茶', 12.00, 'naicha'),
('波霸奶茶', 13.00, 'naicha'),
('芋泥啵啵奶茶', 16.00, 'naicha'),
('黑糖珍珠奶茶', 15.00, 'naicha'),
('茉莉奶绿', 11.00, 'naicha'),
('四季春奶茶', 10.00, 'naicha'),
('红豆奶茶', 14.00, 'naicha'),
('仙草奶茶', 13.00, 'naicha'),
-- 果茶系列
('满杯橙子', 18.00, 'guocha'),
('杨枝甘露', 19.00, 'guocha'),
('柠檬绿茶', 10.00, 'guocha'),
('百香果绿茶', 12.00, 'guocha'),
('芒果沙冰', 16.00, 'guocha'),
('草莓果茶', 17.00, 'guocha'),
('葡萄多多', 15.00, 'guocha'),
-- 其他
('椰果西米露', 14.00, 'qita'),
('烧仙草', 11.00, 'qita'),
('双皮奶', 13.00, 'qita');

-- 原料库存
INSERT INTO kucun(yuanliao_name, danwei, shuliang, anquan_xian) VALUES
('茶叶', 'g', 5000, 500),
('牛奶', 'ml', 30000, 5000),
('珍珠', 'g', 8000, 1000),
('波霸', 'g', 6000, 800),
('芋泥', 'g', 4000, 500),
('黑糖', 'ml', 3000, 400),
('红豆', 'g', 3000, 400),
('仙草', 'g', 2500, 300),
('椰果', 'g', 3000, 400),
('西米', 'g', 2000, 300),
('糖浆', 'ml', 8000, 1000),
('柠檬', '个', 200, 30),
('橙子', '个', 150, 25),
('芒果', '个', 100, 15),
('草莓', 'g', 2000, 300),
('葡萄', 'g', 1500, 200),
('百香果', '个', 80, 15),
('冰块', 'g', 20000, 3000),
('奶盖', 'ml', 5000, 800),
('杯子(中)', '个', 500, 100),
('杯子(大)', '个', 400, 80),
('吸管', '根', 800, 150);

-- 会员数据
INSERT INTO huiyuan(huiyuan_id, shouji, xingming, yue, jifen) VALUES
('M20251201001', '13800138001', '王小明', 128.50, 580),
('M20251202002', '13900139002', '李小红', 66.00, 320),
('M20251205003', '15012345678', '张大伟', 200.00, 850),
('M20251210004', '18611112222', '陈小芳', 0.00, 100),
('M20251215005', '13712348888', '刘强', 350.00, 1200);

-- 历史营业数据（近7天）
INSERT INTO yingye_tongji(riqi, dingdan_shu, xiaoliang, yingye_e) VALUES
(DATE_SUB(CURDATE(), INTERVAL 7 DAY), 68, 142, 1850.00),
(DATE_SUB(CURDATE(), INTERVAL 6 DAY), 75, 158, 2120.50),
(DATE_SUB(CURDATE(), INTERVAL 5 DAY), 82, 175, 2380.00),
(DATE_SUB(CURDATE(), INTERVAL 4 DAY), 55, 98, 1420.00),
(DATE_SUB(CURDATE(), INTERVAL 3 DAY), 91, 198, 2650.00),
(DATE_SUB(CURDATE(), INTERVAL 2 DAY), 88, 186, 2480.50),
(DATE_SUB(CURDATE(), INTERVAL 1 DAY), 96, 205, 2780.00);

-- 今日订单初始化
INSERT INTO yingye_tongji(riqi, dingdan_shu, xiaoliang, yingye_e) VALUES
(CURDATE(), 0, 0, 0.00);

-- ==================== 提示信息 ====================
-- 登录账号：
--   店长：admin / 123456
--   收银员：zhangsan / 123456
--   收银员：lisi / 123456
