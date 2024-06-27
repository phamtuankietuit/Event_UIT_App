import React, { useEffect, useState } from 'react';
import { Button, FlatList, Text, TouchableOpacity, View, useWindowDimensions } from "react-native";
import { SafeAreaView } from "react-native-safe-area-context";
import Page_Item from '../Page_Item';
import Post_Item from '../Post_Item';



const Search_Content = ({
    listPage,
    listPosts
}) => {
    const [stage, setStage] = useState(true)

    const [listPa, setListPa] = useState([])
    const [listPo, setListPo] = useState([])
    const [day, setDay] = useState(new Date())

    useEffect(() => {
        setListPa(listPage)
        setListPo(listPosts)
    }, []);

    const setLikePa = async (id, value) => {
        let newList = listPa

        newList.map((item, index) => {
            if (newList[index].id === id) newList[index].like = value

        })
        setListPa(newList)
        setDay(new Date())
    }


    useEffect(() => {

    }, [day]);
    return (
        <SafeAreaView className='flex-1'>
            <View className='flex flex-row justify-center mb-3'>
                <TouchableOpacity
                    className={stage === true ? 'w-[40%] bg-blue-500 rounded-lg p-2 rounded-l-full' : 'w-[40%] rounded-lg p-2 border border-slate-400 rounded-l-full'}
                    onPress={() => setStage(true)}
                >
                    <Text className={stage === true ? 'text-white text-center text-[16px]' : 'text-center text-[16px]'}>Bài viết</Text>
                </TouchableOpacity>
                <TouchableOpacity
                    className={stage === false ? 'w-[40%] bg-blue-500 rounded-lg p-2 rounded-r-full' : 'w-[40%] rounded-lg p-2 border border-slate-400 rounded-r-full'}
                    onPress={() => setStage(false)}
                >

                    <Text className={stage === false ? 'text-white text-center text-[16px]' : 'text-center text-[16px]'}>Trang</Text>
                </TouchableOpacity>
            </View>
            {
                stage === true ? (
                    <FlatList
                        data={listPo}
                        showsVerticalScrollIndicator={false}
                        className='mx-2 bg-transparent'
                        renderItem={({ item }) => <Post_Item item={item} />}
                    />
                ) : (
                    <FlatList
                        data={listPa}
                        showsVerticalScrollIndicator={false}
                        className='mx-2 bg-transparent'
                        renderItem={({ item }) => <Page_Item item={item} setLike={setLikePa} />}
                    />
                )
            }

        </SafeAreaView>
    );
}

export default Search_Content