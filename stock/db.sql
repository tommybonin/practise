-- 财务报表表格
CREATE TABLE financial_statements (
    id INT PRIMARY KEY AUTO_INCREMENT COMMENT '主键id', 
    stock_id INT NOT NULL COMMENT '股票id', 
    report_date DATE NOT NULL COMMENT '报告日期', 
    revenue DECIMAL(15,2) COMMENT '收入', 
    net_income DECIMAL(15,2) COMMENT '净收入', 
    earnings_per_share DECIMAL(8,3) COMMENT '每股收益', 
    total_assets DECIMAL(20,2) COMMENT '总资产', 
    total_liabilities DECIMAL(20,2) COMMENT '总负债', 
    total_equity DECIMAL(20,2) COMMENT '净资产', 
    FOREIGN KEY (stock_id) REFERENCES stocks(id) COMMENT '外键关联stocks表id字段'
);

-- 股票基本信息表
CREATE TABLE stocks (
    id INT PRIMARY KEY AUTO_INCREMENT COMMENT '主键id', 
    name VARCHAR(255) NOT NULL COMMENT '股票名称', 
    symbol VARCHAR(10) UNIQUE NOT NULL COMMENT '股票代码，唯一', 
    exchange VARCHAR(50) NOT NULL COMMENT '交易所', 
    industry VARCHAR(100) COMMENT '行业', 
    market_cap DECIMAL(20,2) COMMENT '市值', 
    listed_date DATE COMMENT '上市日期', 
    is_active BOOLEAN DEFAULT true COMMENT '是否上市'
);

-- 股票公告表
CREATE TABLE stock_announcements (
    id INT PRIMARY KEY AUTO_INCREMENT COMMENT '主键id', 
    stock_id INT NOT NULL COMMENT '股票id', 
    announcement_date DATE NOT NULL COMMENT '公告日期', 
    title VARCHAR(255) NOT NULL COMMENT '标题', 
    content TEXT NOT NULL COMMENT '内容', 
    FOREIGN KEY (stock_id) REFERENCES stocks(id) COMMENT '外键关联stocks表id字段'
);

-- 股票历史价格表
CREATE TABLE stock_prices (
    id INT PRIMARY KEY AUTO_INCREMENT COMMENT '主键id', 
    stock_id INT NOT NULL COMMENT '股票id', 
    price_date DATE NOT NULL COMMENT '价格日期', 
    open_price DECIMAL(10,2) COMMENT '开盘价', 
    high_price DECIMAL(10,2) COMMENT '最高价', 
    low_price DECIMAL(10,2) COMMENT '最低价', 
    close_price DECIMAL(10,2) COMMENT '收盘价', 
    volume BIGINT COMMENT '成交量', 
    FOREIGN KEY (stock_id) REFERENCES stocks(id) COMMENT '外键关联stocks表id字段'
);

-- 股票财务数据表
CREATE TABLE financial_data (
    id INT PRIMARY KEY AUTO_INCREMENT COMMENT '主键id', 
    stock_id INT NOT NULL COMMENT '股票id', 
    data_date DATE NOT NULL COMMENT '数据日期', 
    revenue DECIMAL(20,2) COMMENT '收入', 
    net_income DECIMAL(20,2) COMMENT '净收入', 
    earnings_per_share DECIMAL(8,3) COMMENT '每股收益', 
    total_assets DECIMAL(20,2) COMMENT '总资产', 
    total_liabilities DECIMAL(20,2) COMMENT '总负债', 
    total_equity DECIMAL(20,2) COMMENT '净资产', 
    FOREIGN KEY (stock_id) REFERENCES stocks(id) COMMENT '外键关联stocks表id字段'
);

-- 历史K线数据表格
CREATE TABLE k_line_data (
    id INT PRIMARY KEY AUTO_INCREMENT COMMENT '主键id', 
    stock_id INT NOT NULL COMMENT '股票id', 
    data_date DATE NOT NULL COMMENT '数据日期', 
    open_price DECIMAL(10,2) COMMENT '开盘价', 
    high_price DECIMAL(10,2) COMMENT '最高价', 
    low_price DECIMAL(10,2) COMMENT '最低价', 
    close_price DECIMAL(10,2) COMMENT '收盘价', 
    volume BIGINT COMMENT '成交量', 
    FOREIGN KEY (stock_id) REFERENCES stocks(id) COMMENT '外键关联stocks表id字段'
);

-- 股票资讯表
CREATE TABLE stock_news (
    id INT PRIMARY KEY AUTO_INCREMENT COMMENT '主键id', 
    stock_id INT NOT NULL COMMENT '股票id', 
    news_date DATE NOT NULL COMMENT '新闻日期', 
    title VARCHAR(255) NOT NULL COMMENT '标题', 
    content TEXT NOT NULL COMMENT '内容', 
    FOREIGN KEY(stock_id) REFERENCES stocks(id) COMMENT '外键关联stocks表id字段'
);

-- 分红派息表
CREATE TABLE dividends (
    id INT PRIMARY KEY AUTO_INCREMENT COMMENT '主键id', 
    stock_id INT NOT NULL COMMENT '股票id', 
    ex_dividend_date DATE NOT NULL COMMENT '除权日', 
    dividend_amount DECIMAL(10,2) COMMENT '分红金额', 
    FOREIGN KEY (stock_id) REFERENCES stocks(id) COMMENT '外键关联stocks表id字段'
);

-- 股本变动表
CREATE TABLE share_changes (
    id INT PRIMARY KEY AUTO_INCREMENT COMMENT '主键id', 
    stock_id INT NOT NULL COMMENT '股票id', 
    change_date DATE NOT NULL COMMENT '变动日期', 
    outstanding_shares BIGINT COMMENT '流通股数', 
    FOREIGN KEY (stock_id) REFERENCES stocks(id) COMMENT '外键关联stocks表id字段'
);

-- 股东持股表
CREATE TABLE shareholder_holdings (
    id INT PRIMARY KEY AUTO_INCREMENT COMMENT '主键id', 
    stock_id INT NOT NULL COMMENT '股票id', 
    holding_date DATE NOT NULL COMMENT '持股日期', 
    shareholder_name VARCHAR(255) NOT NULL COMMENT '股东名称', 
    shares_owned BIGINT COMMENT '持有股数', 
    FOREIGN KEY (stock_id) REFERENCES stocks(id) COMMENT '外键关联stocks表id字段'
);

-- 董事会决议表
CREATE TABLE board_resolutions (
    id INT PRIMARY KEY AUTO_INCREMENT COMMENT '主键id', 
    stock_id INT NOT NULL COMMENT '股票id', 
    resolution_date DATE NOT NULL COMMENT '决议日期', 
    title VARCHAR(255) NOT NULL COMMENT '标题', 
    content TEXT NOT NULL COMMENT '内容', 
    FOREIGN KEY (stock_id) REFERENCES stocks(id) COMMENT '外键关联stocks表id字段'
);

-- 股票交易记录表
CREATE TABLE stock_trades (
    id INT PRIMARY KEY AUTO_INCREMENT COMMENT '主键id', 
    stock_id INT NOT NULL COMMENT '股票id', 
    trade_date DATE NOT NULL COMMENT '交易日期', 
    buy_sell_indicator CHAR(1) COMMENT '买卖指示（B为买入，S为卖出）', 
    quantity BIGINT COMMENT '数量', 
    price DECIMAL(10,2) COMMENT '成交价格', 
    FOREIGN KEY (stock_id) REFERENCES stocks(id) COMMENT '外键关联stocks表id字段'
);

-- 业绩预告表
CREATE TABLE performance_forecasts (
    id INT PRIMARY KEY AUTO_INCREMENT COMMENT '主键id', 
    stock_id INT NOT NULL COMMENT '股票id', 
    forecast_date DATE NOT NULL COMMENT '预告日期', 
    earnings_forecast DECIMAL(15,2) COMMENT '收益预测', 
    revenue_forecast DECIMAL(20,2) COMMENT '收入预测', 
    FOREIGN KEY (stock_id) REFERENCES stocks(id) COMMENT '外键关联stocks表id字段'
);

-- 股票评级表
CREATE TABLE stock_ratings (
    id INT PRIMARY KEY AUTO_INCREMENT COMMENT '主键id', 
    stock_id INT NOT NULL COMMENT '股票id', 
    rating_date DATE NOT NULL COMMENT '评级日期', 
    analyst VARCHAR(255) NOT NULL COMMENT '分析师', 
    rating VARCHAR(10) NOT NULL COMMENT '评级等级', 
    target_price DECIMAL(10,2) COMMENT '目标股价', 
    FOREIGN KEY (stock_id) REFERENCES stocks(id) COMMENT '外键关联stocks表id字段'
);

-- 股票交易流通情况表
CREATE TABLE stock_circulation (
    id INT PRIMARY KEY AUTO_INCREMENT COMMENT '主键id', 
    stock_id INT NOT NULL COMMENT '股票id', 
    circulation_date DATE NOT NULL COMMENT '流通日期', 
    circulating_shares BIGINT COMMENT '流通股本', 
    turnover_rate DECIMAL(8,2) COMMENT '换手率', 
    FOREIGN KEY (stock_id) REFERENCES stocks(id) COMMENT '外键关联stocks表id字段'
);

-- 股票市场行情表
CREATE TABLE market_quotes (
    id INT PRIMARY KEY AUTO_INCREMENT COMMENT '主键id', 
    stock_id INT NOT NULL COMMENT '股票id', 
    quote_date DATE NOT NULL COMMENT '报价日期', 
    last_price DECIMAL(10,2) COMMENT '最新价格', 
    bid_price DECIMAL(10,2) COMMENT '买入价格', 
    ask_price DECIMAL(10,2) COMMENT '卖出价格', 
    bid_size BIGINT COMMENT '买入数量', 
    ask_size BIGINT COMMENT '卖出数量', 
    FOREIGN KEY (stock_id) REFERENCES stocks(id) COMMENT '外键关联stocks表id字段'
);

-- 股票分析师报告表
CREATE TABLE analyst_reports (
    id INT PRIMARY KEY AUTO_INCREMENT COMMENT '主键id', 
    stock_id INT NOT NULL COMMENT '股票id', 
    report_date DATE NOT NULL COMMENT '报告日期', 
    analyst VARCHAR(255) NOT NULL COMMENT '分析师', 
    title VARCHAR(255) NOT NULL COMMENT '标题', 
    content TEXT NOT NULL COMMENT '内容', 
    FOREIGN KEY (stock_id) REFERENCES stocks(id) COMMENT '外键关联stocks表id字段'
);

-- 股票交易费用表
CREATE TABLE trading_fees (
    id INT PRIMARY KEY AUTO_INCREMENT COMMENT '主键id', 
    stock_id INT NOT NULL COMMENT '股票id', 
    trade_date DATE NOT NULL COMMENT '交易日期', 
    fee_type VARCHAR(50) NOT NULL COMMENT '费用类型', 
    fee_amount DECIMAL(10,2) COMMENT '费用金额', 
    FOREIGN KEY (stock_id) REFERENCES stocks(id) COMMENT '外键关联stocks表id字段'
);

-- 股票持仓表
CREATE TABLE stock_positions (
    id INT PRIMARY KEY AUTO_INCREMENT COMMENT '主键id', 
    stock_id INT NOT NULL COMMENT '股票id', 
    position_date DATE NOT NULL COMMENT '持仓日期', 
    quantity BIGINT COMMENT '数量', 
    cost_basis DECIMAL(10,2) COMMENT '成本', 
    FOREIGN KEY (stock_id) REFERENCES stocks(id) COMMENT '外键关联stocks表id字段'
);

-- 股票回购表
CREATE TABLE stock_repurchases (
    id INT PRIMARY KEY AUTO_INCREMENT COMMENT '主键id', 
    stock_id INT NOT NULL COMMENT '股票id', 
    repurchase_date DATE NOT NULL COMMENT '回购日期', 
    shares_repurchased BIGINT COMMENT '回购数量', 
    price_paid DECIMAL(10,2) COMMENT '回购价格', 
    FOREIGN KEY (stock_id) REFERENCES stocks(id) COMMENT '外键关联stocks表id字段'
);

-- 股票期权表
CREATE TABLE stock_options (
    id INT PRIMARY KEY AUTO_INCREMENT COMMENT '主键id', 
    stock_id INT NOT NULL COMMENT '股票id', 
    option_date DATE NOT NULL COMMENT '期权日期', 
    option_type VARCHAR(50) NOT NULL COMMENT '期权类型', 
    strike_price DECIMAL(10,2) COMMENT '行权价', 
    expiration_date DATE COMMENT '到期日期', 
    FOREIGN KEY (stock_id) REFERENCES stocks(id) COMMENT '外键关联stocks表id字段'
);

-- 股票质押表
CREATE TABLE stock_pledges (
    id INT PRIMARY KEY AUTO_INCREMENT COMMENT '主键id', 
    stock_id INT NOT NULL COMMENT '股票id', 
    pledge_date DATE NOT NULL COMMENT '质押日期', 
    pledgee_name VARCHAR(255) NOT NULL COMMENT '抵押人', 
    pledged_shares BIGINT COMMENT '抵押股数', 
    pledge_amount DECIMAL(20,2) COMMENT '抵押金额', 
    FOREIGN KEY (stock_id) REFERENCES stocks(id) COMMENT '外键关联stocks表id字段'
);

-- 股票交易结算表格
CREATE TABLE trade_settlements (
    id INT PRIMARY KEY AUTO_INCREMENT COMMENT '主键id', 
    stock_id INT NOT NULL COMMENT '股票id', 
    settlement_date DATE NOT NULL COMMENT '结算日期', 
    quantity BIGINT COMMENT '数量', 
    price DECIMAL(10,2) COMMENT '成交价格', 
    total_amount DECIMAL(20,2) COMMENT '总金额', 
    FOREIGN KEY (stock_id) REFERENCES stocks(id) COMMENT '外键关联stocks表id字段'
);

-- 股票市值表格
CREATE VIEW market_capitalizations AS -- 创建视图
SELECT s.id AS stock_id, s.symbol, s.name, s.market_cap, sp.close_price, 
(s.market_cap * sp.close_price) AS market_value
FROM stocks s 
JOIN stock_prices sp ON s.id = sp.stock_id 
WHERE sp.price_date = (SELECT MAX(price_date) FROM stock_prices WHERE stock_id = s.id); -- 视图SQL查询语句-- 股票行情数据备份表
CREATE TABLE market_data_backup (
    id INT PRIMARY KEY AUTO_INCREMENT COMMENT '主键id', 
    stock_id INT NOT NULL COMMENT '股票id', 
    price_date DATE NOT NULL COMMENT '价格日期', 
    open_price DECIMAL(10,2) COMMENT '开盘价', 
    high_price DECIMAL(10,2) COMMENT '最高价', 
    low_price DECIMAL(10,2) COMMENT '最低价', 
    close_price DECIMAL(10,2) COMMENT '收盘价', 
    volume BIGINT COMMENT '成交量', 
    FOREIGN KEY (stock_id) REFERENCES stocks(id) COMMENT '外键关联stocks表id字段'
);
