import React, { useEffect, useState } from 'react';
import { FlatList, Text, TouchableOpacity, View } from "react-native";
import { SafeAreaView } from "react-native-safe-area-context";
import SearchBar from '../../components/SearchBar';
import Search_Content from '../../components/SearchContent';


const dataPage = [
  {
    id: "1",
    namePage: "CLB Sách và hành động",
    star: 100,
    like: true
  },
  {
    id: "2",
    namePage: "CLB Làn sóng",
    star: 100,
    like: false
  },
  {
    id: "3",
    namePage: "CLB Bóng đá",
    star: 100,
    like: true
  },
  {
    id: 4,
    namePage: "CLB nhận thức",
    star: 100,
    like: false
  },
  {
    id: 5,
    namePage: "CLB Sách và hành động",
    star: 100,
    like: true
  },
  {
    id: 6,
    namePage: "CLB Sách và hành động",
    star: 100,
    like: true
  },
  {
    id: 7,
    namePage: "CLB Sách và hành động",
    star: 100,
    like: false
  },
  {
    id: 8,
    namePage: "CLB Sách và hành động",
    star: 100,
    like: true
  },
]

const dataPost = [
  {
    id: "1",
    namePage: "CLB Sách và hành động",
    content: 'Cùng theo dõi các trận của MSI hôm nay nhé 11h00: G2 vs PSG 16h00: BLG vs T1. Hãy bình chọn để xem ai sẽ dành chiến thắng ',
    like: true,
    images: [
      'https://interfase.info/public/logo/231213161025_UEFA-EURO-2024_znhec.png',
      'https://interfase.info/public/logo/231213161025_UEFA-EURO-2024_znhec.png',
    ]
  },
  {
    id: "2",
    namePage: "CLB Làn sóng",
    content: 'Cùng theo dõi các trận của MSI hôm nay nhé 11h00: G2 vs PSG 16h00: BLG vs T1',
    like: false,
    images: [
      'https://interfase.info/public/logo/231213161025_UEFA-EURO-2024_znhec.png',
      'https://interfase.info/public/logo/231213161025_UEFA-EURO-2024_znhec.png',
      'https://interfase.info/public/logo/231213161025_UEFA-EURO-2024_znhec.png',
      'https://interfase.info/public/logo/231213161025_UEFA-EURO-2024_znhec.png',
    ]
  },
  {
    id: "3",
    namePage: "CLB Bóng đá",
    content: 'Cùng theo dõi các trận của MSI hôm nay nhé 11h00: G2 vs PSG 16h00: BLG vs T1',
    like: true,
    images: [
      'https://interfase.info/public/logo/231213161025_UEFA-EURO-2024_znhec.png',
      'https://interfase.info/public/logo/231213161025_UEFA-EURO-2024_znhec.png',
      'https://interfase.info/public/logo/231213161025_UEFA-EURO-2024_znhec.png',
      'https://interfase.info/public/logo/231213161025_UEFA-EURO-2024_znhec.png',
    ]
  },
  {
    id: 4,
    namePage: "CLB nhận thức",
    content: 'Cùng theo dõi các trận của MSI hôm nay nhé 11h00: G2 vs PSG 16h00: BLG vs T1',
    like: false,
    images: [
      'https://interfase.info/public/logo/231213161025_UEFA-EURO-2024_znhec.png',
    ]
  },
  {
    id: 5,
    namePage: "CLB Sách và hành động",
    content: 'Cùng theo dõi các trận của MSI hôm nay nhé 11h00: G2 vs PSG 16h00: BLG vs T1',
    like: true,
    images: [
      'https://interfase.info/public/logo/231213161025_UEFA-EURO-2024_znhec.png',
      'https://interfase.info/public/logo/231213161025_UEFA-EURO-2024_znhec.png',
    ]
  },
  {
    id: 6,
    namePage: "CLB Sách và hành động",
    content: 'Cùng theo dõi các trận của MSI hôm nay nhé 11h00: G2 vs PSG 16h00: BLG vs T1',
    like: true,
    images: [
      'https://interfase.info/public/logo/231213161025_UEFA-EURO-2024_znhec.png',
      'https://interfase.info/public/logo/231213161025_UEFA-EURO-2024_znhec.png',
      'https://interfase.info/public/logo/231213161025_UEFA-EURO-2024_znhec.png',
      'https://interfase.info/public/logo/231213161025_UEFA-EURO-2024_znhec.png',
    ]
  },
  {
    id: 7,
    namePage: "CLB Sách và hành động",
    content: 'Cùng theo dõi các trận của MSI hôm nay nhé 11h00: G2 vs PSG 16h00: BLG vs T1',
    like: false,
    images: [
      'https://interfase.info/public/logo/231213161025_UEFA-EURO-2024_znhec.png',
      'https://interfase.info/public/logo/231213161025_UEFA-EURO-2024_znhec.png',
      'https://interfase.info/public/logo/231213161025_UEFA-EURO-2024_znhec.png',
      'https://interfase.info/public/logo/231213161025_UEFA-EURO-2024_znhec.png',
    ]
  },
  {
    id: 8,
    namePage: "CLB Sách và hành động",
    content: 'Cùng theo dõi các trận của MSI hôm nay nhé 11h00: G2 vs PSG 16h00: BLG vs T1',
    like: true,
    images: [
      'https://interfase.info/public/logo/231213161025_UEFA-EURO-2024_znhec.png',
      'https://interfase.info/public/logo/231213161025_UEFA-EURO-2024_znhec.png',
      'https://interfase.info/public/logo/231213161025_UEFA-EURO-2024_znhec.png',
      'https://interfase.info/public/logo/231213161025_UEFA-EURO-2024_znhec.png',
      'https://interfase.info/public/logo/231213161025_UEFA-EURO-2024_znhec.png',
    ]
  },
]

const Search = () => {
  const [value, setValue] = useState('')

  const search = () => {
    console.log(value)
  }
  return (
    <SafeAreaView className='flex-1'>
      <View className='mx-4 my-2'>
        <SearchBar value={value} handleChange={setValue} placeholder='Tìm kiếm bài viết hoặc trang' search={search} />
      </View>
      <Search_Content listPage={dataPage} listPosts={dataPost} />
    </SafeAreaView>
  )
}

export default Search
