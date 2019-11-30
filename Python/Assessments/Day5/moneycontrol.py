from requests import get

from bs4 import BeautifulSoup

url='http://www.moneycontrol.com'
response=get(url)
soup=BeautifulSoup(response.text,'html.parser')

toploss = soup.find_all('div',attrs={'id':'tlNifty'})
print("Top-Losers in NIFTY")
for losscompany in toploss:
    links = losscompany.find_all('a')
    for link in links[:-1]:
        print(link.get('title'))
