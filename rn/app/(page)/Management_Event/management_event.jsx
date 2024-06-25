import React, { useState, useEffect } from 'react';
import { SafeAreaView } from "react-native-safe-area-context";
import { FlatList, Text, TouchableOpacity, View } from "react-native";
import Event_Item from '../../../components/Event_Item';
import { AntDesign } from '@expo/vector-icons';
const data = [
    {
        id: "1",
        namePage: "CLB Sách và hành động",
        des: "Đã nhắc đế bạn và nhiều người khác trong bài viết của họ ",
        time: "20/05/2024 15:30",
        read: true
    },
    {
        id: "2",
        namePage: "CLB Làn sóng",
        des: "Đã nhắc đế bạn và nhiều người khác trong bài viết của họ ",
        time: "20/05/2024 15:30",
        read: false
    },
    {
        id: "3",
        namePage: "CLB Bóng đá",
        des: "Đã nhắc đế bạn và nhiều người khác trong bài viết của họ ",
        time: "20/05/2024 15:30",
        read: true
    },
    {
        id: 4,
        namePage: "CLB nhận thức",
        des: "Đã nhắc đế bạn và nhiều người khác trong bài viết của họ ",
        time: "20/05/2024 15:30",
        read: true
    },
    {
        id: 5,
        namePage: "CLB Sách và hành động",
        des: "Đã nhắc đế bạn và nhiều người khác trong bài viết của họ ",
        time: "20/05/2024 15:30",
        read: true
    },
    {
        id: 6,
        namePage: "CLB Sách và hành động",
        des: "Đã nhắc đế bạn và nhiều người khác trong bài viết của họ ",
        time: "20/05/2024 15:30",
        read: false
    },
    {
        id: 7,
        namePage: "CLB Sách và hành động",
        des: "Đã nhắc đế bạn và nhiều người khác trong bài viết của họ ",
        time: "20/05/2024 15:30",
        read: true
    },
    {
        id: 8,
        namePage: "CLB Sách và hành động",
        des: "Đã nhắc đế bạn và nhiều người khác trong bài viết của họ ",
        time: "20/05/2024 15:30",
        read: false
    },
]
function management_event() {
    return (
        <SafeAreaView className='flex-1 bg-slate-50'>
            <View className='flex justify-center items-center flex-col mt-3 my-2 bg-white'>
                <Text className='text-xl text-sky-600 font-semibold'>Quản lý sự kiện</Text>
            </View>
            <FlatList
                data={data}
                className='mx-2 bg-transparent'
                showsVerticalScrollIndicator={false}
                renderItem={({ item }) => <Event_Item item={item} />}
            />
            <View className='justify-center items-center my-2 absolute right-3 bottom-3'>
                <TouchableOpacity className='p-3 bg-blue-500  rounded-full'>
                    <AntDesign name="plus" size={24} color="white" />
                </TouchableOpacity>
            </View>
        </SafeAreaView>
    );
}

export default management_event;