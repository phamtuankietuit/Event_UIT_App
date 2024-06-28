import {
  View,
  Text,
  Image,
  TouchableOpacity,
  ActivityIndicator,
  FlatList,
} from "react-native"

import React, { memo, useEffect, useState } from "react"
import MyHeader from "../../components/MyHeader"
import EventItem from "../../components/Event_Item"
import { useLocalSearchParams } from "expo-router"
import * as PageServices from "../../apiServices/pageServices"

const PageDetail = () => {
  const [data, setData] = useState([])
  const [isLoading, setIsLoading] = useState(false)
  const params = useLocalSearchParams()
  const [obj, setObj] = useState("")
  useEffect(() => {
    const fetchApi = async () => {
      const response = await PageServices.getPage(params.id).catch((error) => {
        // xử lý lỗi
        if (error.response) {
          if (error.response.status === 401) {
            showToastWithGravity("Vui lòng kiểm tra lại email hoặc mật khẩu")
          } else if (error.response.status === 403) {
            showToastWithGravity("Tài khoản đã bị vô hiệu hóa")
          }
        } else {
          showToastWithGravity("Có lỗi xảy ra")
        }
      })

      if (response) {
        // Xử lý nếu response trả về
        setObj(response)
        setData(response?.hostedEvent)
      }
    }
    fetchApi()
  }, [])
  return (
    <View className='relative flex-1'>
      <View className='absolute left-0 top-0 -z-10 h-[230px] w-full rounded-b-3xl bg-blue-500'></View>
      <MyHeader title={"Chi tiết trang"} />
      <View className='mx-auto mt-5 flex-row justify-center rounded bg-white p-3 shadow shadow-black'>
        <Image
          className='h-24 w-24 rounded-full'
          source={{
            uri: obj?.avatarUrl,
          }}
        ></Image>
        <View className='ml-3'>
          <Text className='text-xl font-medium'>{obj?.name}</Text>
          <Text className=''>{obj?.totalFollowers} người theo dõi</Text>
          <TouchableOpacity className='mt-3 flex-row items-center justify-center rounded bg-blue-500 px-3 py-2'>
            <Text className='font-medium text-white'>Theo dõi</Text>
            {/* <ActivityIndicator size='small' color='#ffffff' /> */}
          </TouchableOpacity>
        </View>
      </View>

      <View className='mx-auto mt-2 min-w-[300px] max-w-[350px] items-center rounded bg-white p-3 shadow shadow-black'>
        <Text className='text-base font-medium'>Giới thiệu</Text>
        <Text numberOfLines={5} ellipsizeMode='tail'>
          {obj?.description}
        </Text>
      </View>

      <View className='mt-3 flex-1'>
        {isLoading ? (
          <View className='h-full rounded-t-2xl bg-white px-3 py-2'>
            <ActivityIndicator size='large' color='#0000ff' />
          </View>
        ) : (
          <FlatList
            className='rounded-t-2xl bg-white px-3 py-2 pt-3 shadow shadow-black'
            data={data}
            keyExtractor={(item) => item.id}
            renderItem={({ item }) => <EventItem item={item} />}
            showsVerticalScrollIndicator={false}
            // refreshControl={
            //   <RefreshControl
            //     refreshing={refreshing}
            //     onRefresh={onRefresh}
            //     colors={["#3A57E8"]}
            //     tintColor='#3A57E8'
            //     progressViewOffset={20}
            //   />
            // }
            ListFooterComponent={<View className='mb-52'></View>}
          />
        )}
      </View>
    </View>
  )
}

export default PageDetail
