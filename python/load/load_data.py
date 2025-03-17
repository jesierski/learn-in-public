# Load data into data frame by using SQL

# Import data
# https://github.com/datacharmer/test_db
# Use employees.sql
import mysql.connector
connection = mysql.connector.connect(host='localhost',
                                     database='test_db',
                                     user='root',
                                     password='<PASSWORD>')

