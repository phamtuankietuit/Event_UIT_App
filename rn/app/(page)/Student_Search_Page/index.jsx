import SearchBar from '@/components/SearchBar';
import Student_Search from '@/components/Student_Search';
import React, { useEffect, useState } from 'react';
import { FlatList, Text, TouchableOpacity, View } from "react-native";
import { SafeAreaView } from "react-native-safe-area-context";

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
        content: 'Cùng theo dõi các trận của MSI hôm nay nhé 11h00: G2 vs PSG 16h00: BLG vs T1',
        like: true
    },
    {
        id: "2",
        namePage: "CLB Làn sóng",
        content: 'Cùng theo dõi các trận của MSI hôm nay nhé 11h00: G2 vs PSG 16h00: BLG vs T1',
        like: false
    },
    {
        id: "3",
        namePage: "CLB Bóng đá",
        content: 'Cùng theo dõi các trận của MSI hôm nay nhé 11h00: G2 vs PSG 16h00: BLG vs T1',
        like: true
    },
    {
        id: 4,
        namePage: "CLB nhận thức",
        content: 'Cùng theo dõi các trận của MSI hôm nay nhé 11h00: G2 vs PSG 16h00: BLG vs T1',
        like: false
    },
    {
        id: 5,
        namePage: "CLB Sách và hành động",
        content: 'Cùng theo dõi các trận của MSI hôm nay nhé 11h00: G2 vs PSG 16h00: BLG vs T1',
        like: true
    },
    {
        id: 6,
        namePage: "CLB Sách và hành động",
        content: 'Cùng theo dõi các trận của MSI hôm nay nhé 11h00: G2 vs PSG 16h00: BLG vs T1',
        like: true
    },
    {
        id: 7,
        namePage: "CLB Sách và hành động",
        content: 'Cùng theo dõi các trận của MSI hôm nay nhé 11h00: G2 vs PSG 16h00: BLG vs T1',
        like: false
    },
    {
        id: 8,
        namePage: "CLB Sách và hành động",
        content: 'Cùng theo dõi các trận của MSI hôm nay nhé 11h00: G2 vs PSG 16h00: BLG vs T1',
        like: true
    },
]
export default function Student_Search_Page() {
    const [value, setValue] = useState('')

    const search = () => {
        console.log(value)
    }

    return (
        <SafeAreaView className='flex-1'>
            <View className='mx-4 my-2'>
                <SearchBar value={value} handleChange={setValue} placeholder='Tìm kiếm bài viết hoặc trang' search={search} />
            </View>

            <Student_Search listPage={dataPage} listPosts={dataPost} />

        </SafeAreaView>
    );
}